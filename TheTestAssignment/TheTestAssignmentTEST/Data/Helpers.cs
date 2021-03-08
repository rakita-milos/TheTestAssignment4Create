using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheTestAssignmentTEST.Data
{
    public class Helpers
    {
        public static void BtnJsClick(IWebElement btn)
        {
            String javascript = "arguments[0].click()";
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)Drivers.driver;
            jsExecutor.ExecuteScript(javascript, btn);
        }
    }
}
