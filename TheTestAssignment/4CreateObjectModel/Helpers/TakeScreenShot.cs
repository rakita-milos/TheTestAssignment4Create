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

            ss.SaveAsFile(@"D:\@Projekti\MinistarstvoFinansija-CARINA\MinFinCarina-Test-Aplikacije\MinFinCarina_Test_App\MinFinCarina_Test_App\Carina_Test\Slike\" + Name + " - " + timeNow + ".png");
        }

        public static void ScreenShootFullScreen() //Uhvati SS celog ekrana sa prozorom browsera
        {
            //Rectangle bounds = Screen.GetBounds(Point.Empty);
            //using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            //{
            //    //using (Graphics g = Graphics.FromImage(bitmap))
            //    //{
            //    //    g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
            //    //}
            //    //string directoryName = new FileInfo(Assembly.GetExecutingAssembly().Location).DirectoryName;

            //    ////bitmap.Save(@"..\..\..\ProcurementFlowPageObject\bin\Debug\ScreenshotFailure\screenshot_full " + timeNow + ".png", System.Drawing.Imaging.ImageFormat.Png);
            //    //bitmap.Save(@"..\..\..\ProcurementFlowPageObject\bin\Debug\ScreenshotFailure/screenshot_full " + timeNow + ".png", System.Drawing.Imaging.ImageFormat.Png);

            //    //Screenshot ss = ((ITakesScreenshot)Driver.driver).GetScreenshot();
            //    //ss.SaveAsFile(@"..\..\..\ProcurementFlowPageObject\bin\Debug\ScreenshotFailure\screenshot_full " + timeNow + ".png", ImageFormat.Png);

            //    var screenshotDriver = Driver.driver as ITakesScreenshot;
            //    Screenshot screenshot = screenshotDriver.GetScreenshot();
            //    var bmpScreen = new Bitmap(new MemoryStream(screenshot.AsByteArray));
            //}
        }

        public static void ScreenShoot() //Uhvati SS, ali odseče delove browser-a (ne vidi se URL bar itd...
        {
            /*
            Screenshot ss = ((ITakesScreenshot)Driver.driver).GetScreenshot();
            ss.SaveAsFile(@"..\..\..\PageObjectModel\bin\Debug\ScreenshotFailure\screenshot " + timeNow + ".png", System.Drawing.Imaging.ImageFormat.Png);
            */
        }

        //private readonly string path = ".//screens//";

        //public void MakeScreenshot(IWebDriver driver, string testName)
        //{
        //    string timestamp = DateTime.Now.ToString("yyyy-MM-dd-hhmm-ss");
        //    var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
        //    screenshot.SaveAsFile($"{this.path}{timestamp} {testName}", ImageFormat.Jpeg);
        //}
    }
}
