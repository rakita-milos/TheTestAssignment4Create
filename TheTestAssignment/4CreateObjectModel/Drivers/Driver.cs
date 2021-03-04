using OpenQA.Selenium;

namespace _4CreateObjectModel.Drivers
{
    public class Driver
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
            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("window.scrollBy(0,-10000)");
        }

    }
}
