using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FlaUI.Core;
using FlaUI.UIA3;
using FlaUI.Core.Conditions;
using FlaUI.Core.AutomationElements;
using FunctionalityTests.DataReturn;

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



    }
}
