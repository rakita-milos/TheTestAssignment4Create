using NUnit.Framework;
using TheTestAssignmentTEST.Helpers;

namespace TheTestAssignmentTEST.Test
{
    [TestFixture]
    class TestGmail:TestBase
    {
        [Test]
        public void VerifyNumberUnreadEmail()
        {
            TestProjectHelper.runner.Run(new GmailTest());
        }

    }
}

