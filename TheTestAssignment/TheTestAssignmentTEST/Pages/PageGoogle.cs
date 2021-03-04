using _4CreateObjectModel.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheTestAssignmentTEST.Pages
{
    public class PageGoogle
    {
        public PageGoogle(IWebDriver _driver)
        {
            _driver = Driver.driver;
        }
        #region Element from page
        IWebElement tbSearch => Driver.driver.FindElement(By.Name("q"));
        IWebElement btnGoogleSearch => Driver.driver.FindElement(By.Name("btnK"));
        IWebElement searchResult => Driver.driver.FindElement(By.XPath("//div[@class='g'][1]//h3[@class='LC20lb DKV0Md']/span"));

        //Sign in
        IWebElement btnSignIn => Driver.driver.FindElement(By.CssSelector("a.gb_4.gb_5.gb_ae.gb_4c"));
        IWebElement tbEmail => Driver.driver.FindElement(By.Id("identifierId"));
        IWebElement btnNextEm => Driver.driver.FindElement(By.CssSelector("VfPpkd-RLmnJb"));
        IWebElement tbPassword => Driver.driver.FindElement(By.Name("password"));
        IWebElement btnNextPass => Driver.driver.FindElement(By.XPath("//div[@id='passwordNext']//button"));

        //GMAIL
        IWebElement btnGmail => Driver.driver.FindElement(By.CssSelector("gb_g"));

        #endregion

        #region Method
        public void EnterSubmitSearchText(string searchText)
        {
            tbSearch.SendKeys(searchText);
            btnGoogleSearch.Click();
        }
        
        public void IsFirstResult4Create(string expectedResult)
        {
            Assert.AreEqual(expectedResult, searchResult.Text, "Site is not the first at the search list");
        }


        #endregion


    }
}
