using OpenQA.Selenium;

namespace TheTestAssignmentTEST.Helpers
{
    public class Drivers
    {
        public static IWebDriver driver;

        public static void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public static void RefreshPage()
        {
            driver.Navigate().Refresh();
        }

        public static void ScrollToTheTop()
        {
            ((IJavaScriptExecutor)Drivers.driver).ExecuteScript("window.scrollBy(0,-10000)");
        }
    }
}
