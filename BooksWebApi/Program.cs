using Microsoft.EntityFrameworkCore;
using BooksWebApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

//// comment it if need to work with DataBase
builder.Services.AddDbContext<BooksAppContext>(options => options.UseInMemoryDatabase("BooksDB"));

//// uncomment it if need to work with DataBase
//builder.Services.AddDbContext<BooksAppContext>(options =>
//options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();

app.Run();
