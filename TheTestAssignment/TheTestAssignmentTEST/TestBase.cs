using NUnit.Framework;
using TestProject.Common.Enums;
using TestProject.SDK;
using TheTestAssignmentTEST.Helpers;

namespace TheTestAssignmentTEST
{
    public class TestBase 
    {
        
        [SetUp]
        public void SetUp()
        {
            TestProjectHelper.runner = new RunnerBuilder(TestProjectHelper.DevToken).AsWeb(AutomatedBrowserType.InternetExplorer).Build();
        }

        [TearDown]
        public void TearDown()
        {
            TestProjectHelper.runner.Dispose();
        }

    }
}
