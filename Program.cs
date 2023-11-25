using Microsoft.AspNetCore.Builder;
using MyWorkerService;

//var builder = Host.CreateApplicationBuilder(args);
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHostedService<Worker>();

builder.Services.AddWindowsService();

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var host = builder.Build();

// Configure the HTTP request pipeline.
if (host.Environment.IsDevelopment())
{
    host.UseSwagger();
    host.UseSwaggerUI();
}

host.MapControllers();

host.Run();
