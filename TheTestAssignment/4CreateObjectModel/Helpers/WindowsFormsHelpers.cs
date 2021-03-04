using AutoIt;

namespace _4CreateObjectModel.Helpers
{
    public class WindowsFormsHelpers
    {
        //For Chrome and Firefox
        public static void SignToBrowser(string username, string password)
        {
            AutoItX.WinWaitActive("Authentication Required", "", 0);
            AutoItX.ControlClick("MozillaDialogClass", "", "");
            AutoItX.Send(username);
            AutoItX.Send("{TAB}");
            AutoItX.Send(password);
            AutoItX.Send("{ENTER}");
        }

        //For Internet Explorer
        public static void SignToBrowserChrome(string username, string password)
        {
            AutoItX.WinWaitActive("Sign in", "", 0);
            AutoItX.Send(username);
            AutoItX.Send("{TAB}");
            AutoItX.Send(password);
            AutoItX.Send("{ENTER}");
        }

        //For Internet Explorer
        public static void SignToBrowserIE(string username, string password)
        {
            AutoItX.WinWaitActive("Windows Security", "", 0);
            AutoItX.Send(username);
            AutoItX.Send("{TAB}");
            AutoItX.Send(password);
            AutoItX.Send("{ENTER}");
        }

        public static void SignToBrowser(string username, string password, string titleLogInWPF)
        {
            AutoItX.WinWaitActive(titleLogInWPF, "", 2000);
            AutoItX.Send(username);
            AutoItX.Send("{TAB}");
            AutoItX.Send(password);
            AutoItX.Send("{ENTER}");
        }

    }
}
