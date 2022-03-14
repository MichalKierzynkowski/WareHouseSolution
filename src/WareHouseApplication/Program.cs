using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using WareHouseApplication.Forms;


namespace WareHouseApplication;

public static class Program
{
    public static IConfiguration Configuration;
    public static IServiceProvider ServiceProvider { get; set; }
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        ConfigureServices();
        Application.Run(new MainMenu());




    }
    static void ConfigureServices()
    {
        var services = new ServiceCollection();

        ServiceProvider = services.BuildServiceProvider();

    }


}