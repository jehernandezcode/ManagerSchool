using FluentValidation.AspNetCore;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Application.Teacher.Dtos;
using SchoolManagement.Infrastructure.Persistence.Context;
using AutoMapper;
using SchoolManagement.Application.Mappings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Configuración del DbContext con SQL Server
var connectionString = builder.Configuration.GetConnectionString("Database");
builder.Services.AddDbContext<SchoolDbContext>(options =>
    options.UseSqlServer(connectionString,
        b => b.MigrationsAssembly("SchoolManagement.Infrastructure")).EnableSensitiveDataLogging()
           .LogTo(Console.WriteLine, LogLevel.Information));

//fluentValidation
builder.Services.AddValidatorsFromAssembly(typeof(CreateCourseDto).Assembly);
builder.Services.AddControllers().AddFluentValidation();

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});

// Construye el mapper y agrégalo al contenedor
var mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
