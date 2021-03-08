using OpenQA.Selenium;
using System;

namespace TheTestAssignmentTEST.Helpers
{
    public class Helper
    {
        public static void BtnJsClick(IWebElement btn)
        {
            String javascript = "arguments[0].click()";
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)Drivers.driver;
            jsExecutor.ExecuteScript(javascript, btn);
        }
    }
}
