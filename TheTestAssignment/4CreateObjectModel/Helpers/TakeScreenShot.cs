using _4CreateObjectModel.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CreateObjectModel.Helpers
{
    public class TakeScreenShot
    {
        static string timeNow = DateTime.Now.ToLocalTime().ToString("yyyy-MM-dd-hhmm-ss");

        public static void ScreenShootScreen(string Name)
        {
            Screenshot ss = ((ITakesScreenshot)Driver.driver).GetScreenshot();

            ss.SaveAsFile(@".\Slike\" + Name + " - " + timeNow + ".png");
        }
        
    }
}
