using _4CreateObjectModel.Drivers;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace TheTestAssignmentTEST
{
    public class TestBase
    {

        [SetUp]
        public void SetUp()
        {
            Driver.driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Driver.driver.Manage().Window.Maximize();
            Driver.NavigateToUrl(Data.Url.urlSiteEn);
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.driver.Close();
        }

    }
}
