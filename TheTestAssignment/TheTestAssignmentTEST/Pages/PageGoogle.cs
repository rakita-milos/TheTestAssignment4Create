using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TheTestAssignmentTEST.Helpers;

namespace TheTestAssignmentTEST.Pages
{
    public class PageGoogle
    {
        public PageGoogle(IWebDriver _driver)
        {
            _driver = Drivers.driver;
        }
        #region Element from page
        IWebElement tbSearch => Drivers.driver.FindElement(By.Name("q"));
        IWebElement btnGoogleSearch => Drivers.driver.FindElement(By.Name("btnK"));
         public static IWebElement searchResult => Drivers.driver.FindElement(By.XPath("//div[@class='g'][1]//h3[@class='LC20lb DKV0Md']/span"));
       
        //Sign in
        IWebElement btnSignIn => Drivers.driver.FindElement(By.CssSelector("a.gb_4.gb_5.gb_ae.gb_4c"));
        IWebElement tbEmail => Drivers.driver.FindElement(By.Id("identifierId"));
        IWebElement btnNextEm => Drivers.driver.FindElement(By.CssSelector("button.VfPpkd-LgbsSe.VfPpkd-LgbsSe-OWXEXe-k8QpJ.VfPpkd-LgbsSe-OWXEXe-dgl2Hf.nCP5yc.AjY5Oe.DuMIQc.qIypjc.TrZEUc.lw1w4b > div.VfPpkd-RLmnJb"));
        IWebElement tbPassword => Drivers.driver.FindElement(By.Name("password"));
        IWebElement btnNextPass => Drivers.driver.FindElement(By.XPath("//div[@id='passwordNext']//button"));

        //GMAIL
        IWebElement btnGmail => Drivers.driver.FindElement(By.ClassName("gb_g"));


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

        public void ClickOnSignIn()
        {
            Helper.BtnJsClick(btnSignIn);
            //btnSignIn.Click();
        }
        
        public void SignInToGMail(string email, string password)
        {
            tbEmail.Click();
            tbEmail.SendKeys(email);
            Helper.BtnJsClick(btnNextEm);
            Drivers.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            tbPassword.Click();
            tbPassword.SendKeys(password);
            btnNextPass.Click();
        }
        
        public void ClickOnGmail()
        {
            Helper.BtnJsClick(btnGmail);
        }

        #endregion

    }
}
