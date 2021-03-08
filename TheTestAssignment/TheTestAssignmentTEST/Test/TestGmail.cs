using NUnit.Framework;
using TestProject.Common.Enums;
using TestProject.SDK;
using TheTestAssignmentTEST.Data;

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

