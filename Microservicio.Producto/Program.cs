using Application.Interfaces;
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

builder.Services.AddScoped<IColorProductoQuery, ColorProductoQuery>();
builder.Services.AddScoped<IColorQuery, ColorQuery>();
builder.Services.AddScoped<IProductoQuery, ProductoQuery>();
builder.Services.AddScoped<ITalleProductoQuery, TalleProductoQuery>();
builder.Services.AddScoped<ITalleQuery, TalleQuery>();

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
