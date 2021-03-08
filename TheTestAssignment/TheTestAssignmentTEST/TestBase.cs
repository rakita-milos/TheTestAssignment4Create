using NUnit.Framework;
using TestProject.Common.Enums;
using TestProject.SDK;
using TheTestAssignmentTEST.Data;

namespace TheTestAssignmentTEST
{
    public class TestBase 
    {
        
        [SetUp]
        public void SetUp()
        {
            //Driver.driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            //Driver.driver = new FirefoxDriver(Environment.CurrentDirectory);
            //Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            //radi
            //Driver.driver = new InternetExplorerDriver(".");
            //Driver.driver.Manage().Window.Maximize();
            //Driver.NavigateToUrl(Data.Url.urlSiteEn);
            //Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            TestProjectHelper.runner = new RunnerBuilder(TestProjectHelper.DevToken).AsWeb(AutomatedBrowserType.InternetExplorer).Build();

        }

        [TearDown]
        public void TearDown()
        {
            TestProjectHelper.runner.Dispose();

            //Driver.driver.Close();
        }

    }
}
