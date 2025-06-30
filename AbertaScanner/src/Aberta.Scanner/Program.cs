using System.Text.Json;
using System.Text.Json.Serialization;
using Aberta.Scanner.Contracts.Services;
using Aberta.Scanner.Contracts.Services.Libraries;
using Aberta.Scanner.Services;
using Aberta.Scanner.Services.Libraries;
using Hangfire;
using Hangfire.Dashboard;
using Hangfire.MySql;
using Microsoft.AspNetCore.Http.Json;
using Newtonsoft.Json;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, configuration) =>
    configuration.ReadFrom.Configuration(context.Configuration));

builder.Services.AddScoped<IBookService, BookService>()
    .AddScoped<IVendusService, VendusService>()
    .AddScoped<IOpenLibraryService, OpenLibraryService>()
    .AddScoped<IBnpLibraryService, BnpLibraryService>();

builder.Services.AddHangfire(configuration =>
{
    configuration.UseStorage(
        new MySqlStorage(
            builder.Configuration.GetConnectionString("HangfireConnection"),
            new MySqlStorageOptions
            {
                QueuePollInterval = TimeSpan.FromSeconds(10),
                JobExpirationCheckInterval = TimeSpan.FromHours(1),
                CountersAggregateInterval = TimeSpan.FromMinutes(5),
                PrepareSchemaIfNecessary = true,
                DashboardJobListLimit = 25000,
                TransactionTimeout = TimeSpan.FromMinutes(1),
                TablesPrefix = "Hangfire",
            }
        )
    );
});
builder.Services.AddHangfireServer();

var app = builder.Build();

app.UseHangfireDashboard("/hangfire", new DashboardOptions
{
    Authorization = [new MyAuthorizationFilter()]
});

RecurringJob.AddOrUpdate<IBookService>("VendusProcessing", s => s.VendusProcessing(), Cron.Hourly);
RecurringJob.AddOrUpdate<IBookService>("LibraryProcessing", s => s.UpdateWithLibraries(), Cron.Never);

app.Run();

internal class MyAuthorizationFilter : IDashboardAuthorizationFilter
{
    public bool Authorize(DashboardContext context) => true;
}