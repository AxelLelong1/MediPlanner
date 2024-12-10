using MediCore.Controllers;
using MediCore.ConvertHelper;
using MediCore.Services;

using MediData.Models;

using Microsoft.EntityFrameworkCore;

using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add DbContextFactory
builder.Services.AddDbContextFactory<VarianContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase; // Pour utiliser le format camelCase si besoin
        options.JsonSerializerOptions.Converters.Add(new MediCore.ConvertHelper.DateTimeConverter()); // Ajouter un convertisseur pour DateTime
    });

// CORS configuration
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<CenterService>();
builder.Services.AddSingleton<PatientListService>();
builder.Services.AddScoped<PlanningController>();
builder.Services.AddScoped<AdminController>();

var app = builder.Build();

// Enable CORS
app.UseCors("AllowAllOrigins");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();