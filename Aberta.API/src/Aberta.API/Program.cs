using Aberta.API.Contracts.Services;
using Aberta.API.Services;
using AbertaApi.Contracts.Repositories;
using AbertaApi.Contracts.Services;
using AbertaApi.Contracts.Services.Libraries;
using AbertaApi.Data;
using AbertaApi.Repositories;
using AbertaApi.Services;
using AbertaScanner.Services;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("log.txt",
        rollingInterval: RollingInterval.Day)
    .CreateLogger();

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

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
