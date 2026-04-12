using CleanArchitecutreMovies.Application.Handlers;
using CleanArchitecutreMovies.Core.Repositories;
using CleanArchitecutreMovies.Infrastructure.Data;
using CleanArchitecutreMovies.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(GetMoviesByDirectorNameHandler).Assembly));
builder.Services.AddScoped<IMovieRepository, MovieRepository>();

var configuration = new ConfigurationBuilder()
.AddJsonFile("appsettings.json")
.Build();

var constr = configuration.GetSection("constr").Value;

builder.Services.AddDbContext<MovieContext>(options =>
    options.UseSqlServer(constr));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.Run();
