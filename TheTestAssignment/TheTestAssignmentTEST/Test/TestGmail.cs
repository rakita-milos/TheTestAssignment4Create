using _4CreateObjectModel.Drivers;
using NUnit.Framework;
using TheTestAssignmentTEST.Pages;

namespace TheTestAssignmentTEST.Test
{
    [TestFixture]
    class TestGmail:TestBase
    {
        [Test]
        public void VerifyNumberUnreadEmail()
        {
            PageGoogle pg = new PageGoogle(Driver.driver);
            pg.ClickOnSignIn();
            pg.SignInToGMail(Data.DataForTest.username, Data.DataForTest.password);
            pg.ClickOnGmail();

        }



    }
}
