using OpenQA.Selenium;
using System;
using TheTestAssignmentTEST.Helpers;

namespace TheTestAssignmentTEST.Pages
{
    public class PageGoogleEmail
    {
        public void TestGmail(IWebDriver _driver)
        {
            _driver = Drivers.driver;
        }

        #region Element from Page
        IWebElement numberOfUnReadEmail => Drivers.driver.FindElement(By.CssSelector("div.aio.UKr6le > div.bsU"));

        IWebElement btnUserProfil => Drivers.driver.FindElement(By.CssSelector("a.gb_D.gb_Na.gb_i"));
        IWebElement btnSignOut => Drivers.driver.FindElement(By.CssSelector("a.gb_Db.gb_Uf.gb_3f.gb_Qe.gb_4c"));

        #endregion

        #region Method
        public bool IsNumberOfUnreadEmailGreaterThenZero()
        {
            if (Int32.Parse(numberOfUnReadEmail.Text) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void SignOutFromGmail()
        {
            Helper.BtnJsClick(btnUserProfil);
            Helper.BtnJsClick(btnSignOut);
        }
        #endregion
    }
}
