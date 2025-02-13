using System.Text.Json;
using System.Text.Json.Serialization;
using Aberta.Scanner.Contracts.Services;
using Aberta.Scanner.Contracts.Services.Libraries;
using Aberta.Scanner.Services;
using Aberta.Scanner.Services.Libraries;
using Hangfire;
using Hangfire.Dashboard;
using Microsoft.AspNetCore.Http.Json;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IBookService, BookService>()
    .AddScoped<IVendusService, VendusService>()
    .AddScoped<IOpenLibraryService, OpenLibraryService>()
    .AddScoped<IBnpLibraryService, BnpLibraryService>();

builder.Services.AddHangfire(configuration =>
{
    configuration.UseSqlServerStorage(builder.Configuration.GetConnectionString("HangfireConnection"));
});
builder.Services.AddHangfireServer();

var app = builder.Build();

app.UseHangfireDashboard("/hangfire", new DashboardOptions
{
    Authorization = [new MyAuthorizationFilter()]
});

RecurringJob.AddOrUpdate<IBookService>("VendusProcessing", s => s.VendusProcessing(), Cron.Never);
RecurringJob.AddOrUpdate<IBookService>("LibraryProcessing", s => s.UpdateWithLibraries(), Cron.Never);

app.Run();

internal class MyAuthorizationFilter : IDashboardAuthorizationFilter
{
    public bool Authorize(DashboardContext context) => true;
}
