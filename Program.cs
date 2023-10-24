using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using night_life_sk.Configuration;
using night_life_sk.Data;
using night_life_sk.Mappers;
using night_life_sk.Repositories;
using night_life_sk.Services;
using night_life_sk.Services.persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container for dependency injection.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ScopedServiceProvider>();
builder.Services.AddSingleton<EntityPersistenceService>();
builder.Services.AddSingleton<PartyEventRepository>();
builder.Services.AddSingleton<PartyPlaceRepository>();
builder.Services.AddSingleton<AppUserRepository>();
builder.Services.AddSingleton<BaseMapService>();

builder.Services.AddDbContext<DataContext>(options => options
.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
.UseLazyLoadingProxies(), ServiceLifetime.Transient);

//Log config
LogConfig.ConfigureServices(builder.Services, builder.Configuration);

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
