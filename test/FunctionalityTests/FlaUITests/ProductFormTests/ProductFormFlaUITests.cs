using System.Threading;
using Xunit;
using FlaUI.Core;
using FlaUI.UIA3;
using FlaUI.Core.Conditions;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Input;
using FunctionalityTests.DataReturn;
using FlaUI.Core.WindowsAPI;

namespace FunctionalityTests.FlaUITests.ProductFormTests
{
    public class ProductFormFlaUITests
    {
        public string PathOfApplication { get; set; }
        public ProductFormFlaUITests()
        {
            PathOfApplication = ReturnPathOfFile.Path;
        }

        [Fact]
        public void TestOpeningApp()
        {
            var app = Application.Launch(PathOfApplication);
            var mainWindow = app.GetMainWindow(new UIA3Automation());
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());

            mainWindow.FindFirstDescendant(cf.ByName("Produkty")).AsButton().Click();
            //mainWindow.FindFirstDescendant(cf.ByAutomationId("btnExit")).AsButton().Click();
            //mainWindow.FindFirstDescendant(cf.ByName("OK")).AsButton().Click();
        }

        [Fact]
        public void TestAddNewWareHouse()
        {
            var app = Application.Launch(PathOfApplication);
            var mainWindow = app.GetMainWindow(new UIA3Automation());
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());

            mainWindow.FindFirstDescendant(cf.ByName("Magazyn")).AsButton().Click();
            mainWindow.FindFirstDescendant(cf.ByName("Dodaj")).AsButton().Click();
            Thread.Sleep(2000);
            mainWindow.FindFirstDescendant(cf.ByAutomationId("btnSelectProduct")).AsButton().Click();
            mainWindow.FindFirstDescendant(cf.ByAutomationId("btnLoadData")).AsButton().Click();
            Thread.Sleep(3000);
            Keyboard.Pressing(VirtualKeyShort.TAB);
            Keyboard.Pressing(VirtualKeyShort.TAB);
            Keyboard.Pressing(VirtualKeyShort.TAB);
            Keyboard.Pressing(VirtualKeyShort.TAB);
            Keyboard.Pressing(VirtualKeyShort.TAB);
            Keyboard.Pressing(VirtualKeyShort.TAB);
            Keyboard.Pressing(VirtualKeyShort.TAB);
            Keyboard.Pressing(VirtualKeyShort.ENTER);
            mainWindow.FindFirstDescendant(cf.ByAutomationId("btnPick")).AsButton().Click();

            //mainWindow.FindFirstDescendant(cf.ByAutomationId("btnPick")).AsButton().Click();

        }



    }
}