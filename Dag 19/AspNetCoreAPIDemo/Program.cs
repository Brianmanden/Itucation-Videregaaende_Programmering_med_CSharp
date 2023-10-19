using AspNetCoreAPIDemo.Interfaces;
using AspNetCoreAPIDemo.Models;
using AspNetCoreAPIDemo.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Dependency Injection
builder.Services.AddDbContext<BooksDb>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("BooksDb")));
//builder.Services.AddSingleton<IBooksInterface, BookDatabaseRepository>();

builder.Services.AddScoped<IBooksInterface, BookDatabaseRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
