using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using night_life_sk.Data;
using night_life_sk.Repositories.Event;
using night_life_sk.Repositories.place;
using night_life_sk.Repositories.user;
using night_life_sk.Services;
using night_life_sk.Services.persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container for dependency injection.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ScopedServiceProvider>();
builder.Services.AddSingleton<EntityPersistenceService>();
builder.Services.AddSingleton<IPartyEventRepository, PartyEventRepository>();
builder.Services.AddSingleton<IPartyPlaceRepository, PartyPlaceRepository>();
builder.Services.AddSingleton<IAppUserRepository, AppUserRepository>();

var myConnectionString = Environment.GetEnvironmentVariable("MyDatabaseConnectionString");
if (!string.IsNullOrEmpty(myConnectionString))
{
    builder.Configuration.GetSection("ConnectionStrings")["DefaultConnection"] = myConnectionString;
}

builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
