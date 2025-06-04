
using Serilog;
using ObtenerSolucionesMicroservice.Api.Extensions;
var builder = WebApplication.CreateBuilder(args);
var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile("serilogsettings.json", optional: false, reloadOnChange: true)
    .Build();

builder.Services.InyeccionDeBD(builder.Configuration)
                .InyeccionDeDepenciasClases()
                .InyeccionControllers()
                .InyeccionOtrosServicios(builder.Configuration);

if (!builder.Environment.IsDevelopment())
{
    Log.Logger = new LoggerConfiguration()
.ReadFrom.Configuration(configuration)
.Enrich.FromLogContext()
.CreateLogger();
    builder.Host.UseSerilog();
}


var app = builder.Build();
app.UseCustomConfiguration(app.Environment);
app.Run();