using Microsoft.EntityFrameworkCore;
using RobotInvasionProjectApi.Models;
using RobotInvasionProjectApi.Services;



WebApplicationBuilder builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<HttpClient>();
builder.Services.AddSingleton<LocationService>();


WebApplication app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) 
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// swagger is used for testing only
// this project is server side(back-end) only

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
