using Product.API.Middleware;
using Product.Application;
using Product.Persistence;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddApplication();
builder.Services.RegisterPersistence(builder.Configuration);

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMiddleware<CommonResponseMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();
