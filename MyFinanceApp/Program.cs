using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Hosting;
using MyFinanceApp.Services;
using MyFinanceApp.ViewModels;
using MyFinanceApp.Views;

namespace MyFinanceApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => { });

        // Register services & pages
        builder.Services.AddSingleton<ILocalDatabase, SqliteLocalDatabase>();
        builder.Services.AddSingleton<IApiService, ApiService>();
        builder.Services.AddSingleton<ISyncService, SyncService>();

        builder.Services.AddSingleton<AppShell>();
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<TransactionsPage>();
        builder.Services.AddSingleton<ReportsPage>();
        builder.Services.AddSingleton<SettingsPage>();

        builder.Services.AddTransient<TransactionsViewModel>();
        builder.Services.AddTransient<DashboardViewModel>();

        return builder.Build();
    }
}
