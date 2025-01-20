using FluentValidation.AspNetCore;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Application.Teacher.Dtos;
using SchoolManagement.Infrastructure.Persistence.Context;
using AutoMapper;
using SchoolManagement.Application.Mappings;
using SchoolManagement.Application.Course.Interfaces;
using SchoolManagement.Application.Course.Services;
using SchoolManagement.Application.Grade.Interfaces;
using SchoolManagement.Application.Grade.Services;
using SchoolManagement.Application.Student.Interfaces;
using SchoolManagement.Application.Student.Services;
using SchoolManagement.Application.Teacher.Interfaces;
using SchoolManagement.Application.Teacher.Services;
using SchoolManagement.Domain.Interfaces;
using SchoolManagement.Infrastructure.Persistence.Repositories;
using Microsoft.OpenApi.Models;
using SchoolManagement.Domain.Common;
using Microsoft.AspNetCore.Authentication;
using SchoolManagement.Infrastructure.Authentication;
using SchoolManagement.Application.Authentication.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using SchoolManagement.Application.Authentication.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Manager School", Version = "v1" });
    c.EnableAnnotations();
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. Enter 'Bearer' [space] and then your token in the text input below.",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "bearer"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});

var SecretKey = builder.Configuration.GetValue<string>("Jwt:SecretKey") ?? "";
var Issuer = builder.Configuration.GetValue<string>("Jwt:Issuer") ?? "";
var Audience = builder.Configuration.GetValue<string>("Jwt:Audience") ?? "";
decimal expireAt = builder.Configuration.GetValue<decimal>("Jwt:ExpirationMinutes");

builder.Services.AddScoped<IAuthenticationServiceInfra, AuthentificationServiceInfra>(sp =>
{
    return new AuthentificationServiceInfra(
       Audience, Issuer, SecretKey, expireAt
    );
});
builder.Services.AddScoped<IAutheticationService, SchoolManagement.Application.Authentication.Services.AuthenticationService>();

// Agregar JWT Authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = Issuer,
            ValidAudience = Audience,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey))
        };
    });

// Add services to the container.
builder.Services.AddScoped<IServiceTeacher, ServiceTeacher>();
builder.Services.AddScoped<IServiceCourse, CourseService>();
builder.Services.AddScoped<IServiceStudent, StudentService>();
builder.Services.AddScoped<IServiceGrade, GradeService>();


builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();
builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IGradeRepository, GradeRepository>();
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
