using Microsoft.EntityFrameworkCore;
using WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
//using System.Text.Json.Serialization;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration[
        "ConnectionStrings:ProductConnection"]);
    opts.EnableSensitiveDataLogging(true);
});

//builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddControllers()
    .AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();

builder.Services.Configure<MvcNewtonsoftJsonOptions>(opts =>
{
    opts.SerializerSettings.NullValueHandling
        = Newtonsoft.Json.NullValueHandling.Ignore;
});

builder.Services.Configure<MvcOptions>(opts =>
{
    opts.RespectBrowserAcceptHeader = true;
    opts.ReturnHttpNotAcceptable = true;
});

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApp", Version = "v1" });
});

//builder.Services.Configure<JsonOptions>(opts =>
//{
//    opts.JsonSerializerOptions.DefaultIgnoreCondition
//        = JsonIgnoreCondition.WhenWritingNull;
//});

var app = builder.Build();

app.MapControllers();

app.MapGet("/", () => "Hello World!");

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Webapp");
});

var context = app.Services.CreateScope().ServiceProvider
    .GetRequiredService<DataContext>();
SeedData.SeedDatabase(context);

app.Run();
