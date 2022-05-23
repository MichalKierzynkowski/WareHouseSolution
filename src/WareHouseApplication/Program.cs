using Infrastructure.Data;
using Infrastructure.SqlLiteConnectionSettings;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;
using WareHouseApplication.Forms;

namespace WareHouseApplication;

public static class Program
{
    public static IServiceProvider ServiceProvider { get; private set; }

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        Application.SetHighDpiMode(HighDpiMode.PerMonitor);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        var host = CreateHostBuilder().Build();
        ServiceProvider = host.Services;

        Application.Run(ServiceProvider.GetRequiredService<MainMenu>());

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddEntityFrameworkSqlite().AddDbContext<WareHouseDbContext>();
                    services.AddTransient<MainMenu>();
                    services.AddScoped<ISqlLiteDataAccess, SqlLiteDataAccess>();
                    services.AddSingleton(AutoMapperConfig.Initialize());
                });
        }
    }
}