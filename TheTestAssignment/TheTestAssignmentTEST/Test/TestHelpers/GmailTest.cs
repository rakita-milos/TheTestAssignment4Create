using System;
using TestProject.SDK;
using TestProject.SDK.Tests;
using TestProject.SDK.Tests.Helpers;
using TheTestAssignmentTEST.Data;
using TheTestAssignmentTEST.Pages;

namespace TheTestAssignmentTEST.Test
{
    public class GmailTest : IWebTest
    {
        public ExecutionResult Execute(WebTestHelper helper)
        {
            Drivers.driver = helper.Driver;
            Drivers.NavigateToUrl(Data.Url.urlSiteEn);
            PageGoogle pg = new PageGoogle(Drivers.driver);
            pg.ClickOnSignIn();
            pg.SignInToGMail(Data.DataForTest.username, Data.DataForTest.password);
            pg.ClickOnGmail();
            PageGoogleEmail pge = new PageGoogleEmail();
            if (pge.IsNumberOfUnreadEmailGreaterThenZero())
            {
                pge.SignOutFromGmail();
                return ExecutionResult.Passed;
            }
            else
            {
                pge.SignOutFromGmail();
                return ExecutionResult.Failed;
            }
           
            
        }
    }
}
