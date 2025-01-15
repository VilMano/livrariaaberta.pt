using AbertaScanner.Contracts.Services;
using AbertaScanner.Contracts.Services.Libraries;
using AbertaScanner.Services;
using AbertaScanner.Services.Libraries;
using Hangfire;
using Hangfire.Dashboard;

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
    Authorization = new [] { new MyAuthorizationFilter()}
});

RecurringJob.AddOrUpdate<IBookService>("VendusProcessing", s => s.VendusProcessing(), Cron.Hourly);
RecurringJob.AddOrUpdate<IBookService>("LibraryProcessing", s => s.UpdateWithLibraries(), Cron.Hourly);

app.Run();

public class MyAuthorizationFilter : IDashboardAuthorizationFilter
{
    public bool Authorize(DashboardContext context) => true;
}
