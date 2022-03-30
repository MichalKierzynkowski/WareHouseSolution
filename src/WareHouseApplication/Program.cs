
using System;
using System.Windows.Forms;
using WareHouseApplication.Forms;


namespace WareHouseApplication;

public static class Program
{
    
    public static IServiceProvider ServiceProvider { get; set; }
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
       
        Application.Run(new MainMenu());




    }
   


}