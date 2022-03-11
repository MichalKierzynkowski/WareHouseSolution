using System;
using System.Windows.Forms;
using FluentAssertions.Common;
using Microsoft.Extensions.DependencyInjection;
using WareHouseApplication.Forms;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using Configuration = System.Configuration.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;


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