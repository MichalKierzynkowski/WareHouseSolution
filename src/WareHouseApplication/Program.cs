using System;
using System.Windows.Forms;
using FluentAssertions.Common;
using Microsoft.Extensions.DependencyInjection;
using WareHouseApplication.Forms;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using Configuration = System.Configuration.Configuration;

namespace WareHouseApplication;

static class Program
{
    public static  IConfigurationRoot Configuration { get; }
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var services = new ServiceCollection();

        ConfigureServices(services);

        using (ServiceProvider serviceProvider = services.BuildServiceProvider())
        {
            var form1 = serviceProvider.GetRequiredService<MainMenu>();
            Application.Run(form1);


        }
    }

    private static void ConfigureServices(ServiceCollection services)
    {
        services.AddScoped<MainMenu>();
        services.AddSingleton<IConfiguration>(Configuration);
        

    }
}