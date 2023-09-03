# night-life-sk.NET

Set env variable for DB connection:
set MyDatabaseConnectionString=YourConnectionString:D

## Initialize the DB

dotnet clean
dotnet build
dotnet ef migrations add InitialCreate
dotnet ef database update