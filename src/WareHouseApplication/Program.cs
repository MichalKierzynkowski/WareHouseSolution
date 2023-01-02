using ApplicationLayer.Interfaces;
using ApplicationLayer.Mappings;
using ApplicationLayer.Services;
using Domain.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Infrastructure.SqlLiteConnectionSettings;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;
using WareHouseApplication.AllForms.MainMenu;

namespace WareHouseApplication
{
    public static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

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
                        services.AddScoped<IProductService, ProductService>();
                        services.AddScoped<IWareHouseService, WareHouseService>();
                        services.AddEntityFrameworkSqlite().AddDbContext<WareHouseDbContext>();
                        services.AddScoped<IProductRepository, ProductRepository>();
                        services.AddScoped<IWareHouseRepository, WareHouseRepository>();
                        services.AddTransient<MainMenu>();
                        services.AddScoped<ISqlLiteDataAccess, SqlLiteDataAccess>();
                        services.AddSingleton(AutoMapperConfig.Initialize());
                        services.AddScoped<IReturnService, ReturnService>();
                        services.AddScoped<IReturnRepository, ReturnRepository>();
                    });
            }
        }
    }
}