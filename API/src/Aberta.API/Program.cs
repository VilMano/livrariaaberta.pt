using System.Text.Json.Serialization;
using Aberta.API.Contracts.Services;
using Aberta.API.Models.Auth;
using Aberta.API.Repositories;
using Aberta.API.Services;
using AbertaApi.Contracts.Repositories;
using AbertaApi.Contracts.Services;
using AbertaApi.Contracts.Services.Libraries;
using AbertaApi.Data;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, configuration) =>
    configuration.ReadFrom.Configuration(context.Configuration));

builder.Services.AddAuthentication("ApiKey")
    .AddScheme<ApiKeyAuthenticationSchemeOptions, ApiKeyAuthenticationSchemeHandler>(
        "ApiKey",
        opts => opts.ApiKey = builder.Configuration.GetValue<string>("ApiKey")
    );

// Add services to the container.
builder.Services
.AddScoped<IBookService, BookService>()
.AddScoped<IBookRepository, BookRepository>()
.AddScoped<IOpenLibraryService, OpenLibraryService>()
.AddScoped<IBnpLibraryService, BnpLibraryService>()
.AddScoped<IVendusService, VendusService>()
.AddScoped<IImageService, ImageService>()
.AddScoped<ITagRepository, TagRepository>()
.AddScoped<ITagService, TagService>();

var connectionString = builder.Configuration.GetConnectionString("Database");
builder.Services.AddDbContext<Context>(options => {
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

builder.Services.AddAntiforgery();

builder.Services.AddControllers().AddJsonOptions(x =>
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();





var app = builder.Build();

app.UseSerilogRequestLogging();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAntiforgery();

app.UseAuthorization();

app.MapControllers();

app.Run();
