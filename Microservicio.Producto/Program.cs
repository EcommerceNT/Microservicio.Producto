using Application.Interfaces.ICommand;
using Application.Interfaces.IQuerys;
using Application.Interfaces.IService;
using Application.UseCase.Colores;
using Application.UseCase.TallesService;
using Infrastructure.Command;
using Infrastructure.Persistence;
using Infrastructure.Querys;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Custom
var connectionString = builder.Configuration["ConnectionString"];
builder.Services.AddDbContext<ProductoContext>(options => options.UseSqlServer(connectionString));

// Querys
builder.Services.AddScoped<IColorProductoQuery, ColorProductoQuery>();
builder.Services.AddScoped<IColorQuery, ColorQuery>();
builder.Services.AddScoped<IProductoQuery, ProductoQuery>();
builder.Services.AddScoped<ITalleProductoQuery, TalleProductoQuery>();
builder.Services.AddScoped<ITalleQuery, TalleQuery>();

// Command
builder.Services.AddScoped<IColorProductoCommand, ColorProductoCommand>();
builder.Services.AddScoped<IColorCommand, ColorCommand>();
builder.Services.AddScoped<IProductoCommand, ProductoCommand>();
builder.Services.AddScoped<ITalleProductoCommand, TalleProductoCommand>();
builder.Services.AddScoped<ITalleCommand, TalleCommand>();

// Service
builder.Services.AddScoped<IColorService, ColorService>();
builder.Services.AddScoped<ITalleService, TalleService>();

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
