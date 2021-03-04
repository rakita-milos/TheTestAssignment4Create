using _4CreateObjectModel.Drivers;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;

namespace TheTestAssignmentTEST
{
    public class TestBase
    {

        [SetUp]
        public void SetUp()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Window.Maximize();
            Driver.NavigateToUrl(Data.Url.urlSite);
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.driver.Close();
        }

    }
}
