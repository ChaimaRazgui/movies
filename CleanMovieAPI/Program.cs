using CleanMovie.Application.Repositories;
using CleanMovie.Application.Services;
using CleanMovie.Infrastructure.Data;
using CleanMovie.Infrastructure.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MovieDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b=> b.MigrationsAssembly("CleanMovieAPI")));
builder.Services.AddScoped<IMovieRepsitory, MovieRepository>();
builder.Services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
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
