using Microsoft.EntityFrameworkCore;
using XFitness.Api.Services.Services;
using XFitness.Api.Services.Services.Contracts;
using XFitness.Data.Data;
using XFitness.Repositories.Repositories;
using XFitness.Repositories.Repositories.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<XFitnessDbContext>(options =>
options.UseSqlServer(builder.Configuration
        .GetConnectionString("XFitnessDbContext"), b => b.MigrationsAssembly("XFitness.Data")), ServiceLifetime.Transient);

builder.Services.AddScoped<IExerciseService, ExerciseService>();
builder.Services.AddScoped<IExerciseRepository, ExerciseRepository>();

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
