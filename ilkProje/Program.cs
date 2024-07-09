using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Register services with the Startup class
var startup = new Startup();
startup.ConfigureServices(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline with the Startup class
var env = app.Services.GetRequiredService<IWebHostEnvironment>();
startup.Configure(app, env);

app.Run();
