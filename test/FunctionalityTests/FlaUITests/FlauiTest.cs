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

namespace FunctionalityTests.FlaUITests
{
    public class FlauiTest
    {


        [Fact]
        public void Test2()
        {
            var app = FlaUI.Core.Application.Launch(@"C:\Users\Michal\source\repos\MichalKierzynkowski\WareHouseSolution\src\WareHouseApplication\bin\Debug\net6.0-windows/WareHouseApplication.exe");
            var mainWindow = app.GetMainWindow(new UIA3Automation());
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());

            mainWindow.FindFirstDescendant(cf.ByName("Produkty")).AsButton().Click();
            mainWindow.FindFirstDescendant(cf.ByAutomationId("btnExit")).AsButton().Click();
        }
    }
}
