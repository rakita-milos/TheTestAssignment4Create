using _4CreateObjectModel.Drivers;

namespace _4CreateObjectModel.Helpers
{
    public class Login
    {
        public static void LoginURLHttp(string username, string password, string url)
        {
            string fullUrl = "http://" + username + ":" + password + "@" + url;
            Driver.NavigateToUrl(fullUrl);
        }

        public static void LoginURLHttps(string username, string password, string url)
        {
            string fullUrl = "https://" + username + ":" + password + "@" + url;
            Driver.NavigateToUrl(fullUrl);
        }

        public static void LoginURLHttps(string username, string password, string urlShort, string urlFull)
        {
            string fullUrlWithCredentials = "https://" + username + ":" + password + "@" + urlShort;
            Driver.driver.Navigate().GoToUrl(fullUrlWithCredentials);
            Driver.driver.Navigate().GoToUrl(urlFull);
        }

        public static void LoginURLHttpAppSP(string username, string password, string urlApp, string urlSP)
        {
            string spUrlWithCredentials = "http://" + username + ":" + password + "@" + urlSP;
            string appUrlWithCredentials = "http://" + username + ":" + password + "@" + urlApp;
            Driver.driver.Navigate().GoToUrl(spUrlWithCredentials);
            Driver.driver.Navigate().GoToUrl(appUrlWithCredentials);
        }

        public static void LoginWPF(string username, string password, string titleLogInWPF)
        {
            WindowsFormsHelpers.SignToBrowser(username, password, titleLogInWPF);
            WindowsFormsHelpers.SignToBrowser(username, password, titleLogInWPF);
        }
        public static void LoginAppWPF(string username, string password, string titleLogInWPF)
        {
            WindowsFormsHelpers.SignToBrowser(username, password, titleLogInWPF);
        }

    }
}
