using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApi01.Models;
using WebApi01.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<EstrelasContext>(
    options => options.UseInMemoryDatabase("EstrelasContext")
);

builder.Services.AddScoped<EstrelasContext, EstrelasContext>();
builder.Services.AddScoped<SistemaService>();
//builder.Services.AddScoped<EstrelaService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();