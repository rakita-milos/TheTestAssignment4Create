using _4CreateObjectModel.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CreateObjectModel.Helpers
{
    public static class WebElementExtensions
    {
        public static IWebElement RandomElement(this IList<IWebElement> element)
        {
            Random rand = new Random();
            int randomValue = rand.Next(1, element.Count);
            IWebElement ourEl = element[randomValue];
            return ourEl;
        }

        public static string GetSelectedDropDown(this IWebElement element)
        {
            SelectElement ddl = new SelectElement(element);
            return ddl.AllSelectedOptions.First().Text;
        }

        public static string GetSelectedValueFromDropDown(this IWebElement element)
        {
            SelectElement ddl = new SelectElement(element);
            return ddl.SelectedOption.GetAttribute("value");
        }

        public static IList<IWebElement> GetSelectedListOptions(this IWebElement element)
        {
            SelectElement ddl = new SelectElement(element);
            return ddl.AllSelectedOptions;
        }

        public static string GetLinkText(this IWebElement element)
        {
            return element.Text;
        }

        public static void SelectDropDownListByValue(this IWebElement element, string value)
        {
            SelectElement ddl = new SelectElement(element);
            ddl.SelectByValue(value);
        }

        public static void SelectDropDownListByValueReturn(this IWebElement element, string value)
        {
            SelectElement ddl = new SelectElement(element);
            ddl.SelectByText(value);
        }

        public static void SelectDropDownListByText(this IWebElement element, string text)
        {
            SelectElement ddl = new SelectElement(element);
            ddl.SelectByText(text);
        }

        public static void SelectDropDownListByIndex(this IWebElement element, int index)
        {
            SelectElement ddl = new SelectElement(element);
            ddl.SelectByIndex(index);
        }


        public static void Hover(this IWebElement element)
        {
            Actions action = new Actions(Driver.driver);
            action.MoveToElement(element).Perform();
        }

        public static void EnterText(this IWebElement element, string value)
        {
            //element.Click();
            element.Clear();
            element.SendKeys(value);
            Assert.AreEqual(element.GetAttribute("value"), value);
        }

        public static string GetText(this IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static string GetTextFromDDL(this IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }

        public static void SelectFromListBoxByValue(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByValue(value);
        }

        public static void SelectFromListBoxByText(this IWebElement element, string text)
        {
            new SelectElement(element).SelectByText(text);
        }

        public static void SelectFromListBoxByIndex(this IWebElement element, int index)
        {
            new SelectElement(element).SelectByIndex(index);
        }

        public static void Wait(this IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(Driver.driver, new TimeSpan(0, 0, 20));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public static void CbIsCheck(this IWebElement cb, bool isActiveEmpl)
        {
            if (cb.Selected)
            {
                Assert.AreEqual(true, isActiveEmpl);
            }
            else
            {
                Assert.AreEqual(false, isActiveEmpl);
            }
        }


        public static void ElementExistsInList(this IList<IWebElement> list, string element)
        {
            bool isExist = false;
            foreach (IWebElement we in list)
            {
                if (we.Text.Equals(element))
                {
                    isExist = true;
                    break;
                }
            }
            Assert.AreEqual(true, isExist);
        }

        public static void ElementExistsInListWithScroll(this IList<IWebElement> list, string element)
        {
            bool isExist = false;
            foreach (IWebElement we in list)
            {
                ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", we);
                if (we.Text.Equals(element))
                {
                    isExist = true;
                    break;
                }
            }
            Assert.AreEqual(true, isExist);
        }

        public static void ElementNotExistsInList(this IList<IWebElement> list, string element)
        {
            bool isNotExist = true;
            foreach (IWebElement we in list)
            {
                if (we.Text.Equals(element))
                {
                    isNotExist = false;
                    break;
                }
            }
            Assert.AreEqual(true, isNotExist);
        }

        public static void ElementNotExistsInListWithScroll(this IList<IWebElement> list, string element)
        {
            bool isNotExist = true;
            foreach (IWebElement we in list)
            {
                ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", we);
                if (we.Text.Equals(element))
                {
                    isNotExist = false;
                    break;
                }
            }
            Assert.AreEqual(true, isNotExist);
        }

        public static void ElementContainsInList(this IList<IWebElement> list, string element)
        {
            bool isContains = false;
            foreach (IWebElement we in list)
            {
                if (we.Text.Contains(element))
                {
                    isContains = true;
                    break;
                }
            }
            Assert.AreEqual(true, isContains);
        }

        public static void ElementNotContainsInList(this IList<IWebElement> list, string element)
        {
            bool isNotContains = true;
            foreach (IWebElement we in list)
            {
                if (we.Text.Contains(element))
                {
                    isNotContains = false;
                    break;
                }
            }
            Assert.AreEqual(true, isNotContains);
        }

        public static void ClickAllToastMessages(this IList<IWebElement> toastMessageList)
        {
            if (toastMessageList.Count > 0)
            {
                foreach (IWebElement we in toastMessageList)
                {
                    if (we.Displayed)
                    {
                        we.Click();
                    }
                }
            }
        }

        public static void FindElementInTheListByTextAndClick(this IList<IWebElement> list, string element)
        {
            foreach (IWebElement we in list)
            {
                if (we.Text.Equals(element))
                {
                    we.Click();

                }
            }
        }

        public static void FindElementInTheListAndEnterText(this IList<IWebElement> list, string text)
        {
            foreach (IWebElement we in list)
            {
                we.ActionsClick();
                we.ActionsSendKeys(text);

            }
        }

        public static void FindElementInTheListAndCompare(this IList<IWebElement> list, string text)
        {
            foreach (IWebElement we in list)
            {
                we.Text.Equals(text);
            }
        }

        public static void GridTextBoxDoubleClickAndSendKeys(this IWebElement element, string text)
        {
            element.ActionsDoubleClick();
            element.ActionsSendKeys(text);
            element.PressEnter();
        }

        public static string GetAttribeByValue(this IWebElement element)
        {
            string elementValue = element.GetAttribute("value");
            return elementValue;
        }

        public static void ClearTextBox(this IWebElement element)
        {
            element.SendKeys(Keys.Control + "a");
            element.SendKeys(Keys.Delete);
        }

        public static void PressEnter(this IWebElement element)
        {
            element.SendKeys(Keys.Enter);
        }

        //Actions Methods
        public static void ActionsClick(this IWebElement element)
        {
            Actions actions = new Actions(Driver.driver);
            actions.MoveToElement(element);
            actions.Click();
            actions.Build().Perform();
        }

        public static void ActionsDoubleClick(this IWebElement element)
        {
            Actions actions = new Actions(Driver.driver);
            actions.MoveToElement(element);
            actions.DoubleClick();
            actions.Build().Perform();
        }

        public static void ActionsMoveToElement(this IWebElement element)
        {
            Actions actions = new Actions(Driver.driver);
            actions.MoveToElement(element);
            actions.Perform();
        }

        public static void ActionsSendKeys(this IWebElement element, string value)
        {
            Actions actions = new Actions(Driver.driver);
            actions.MoveToElement(element);
            actions.SendKeys(value);
            actions.Perform();
        }

        //probati da se u jendoj metodi ubaci sve tri provere
        public static void EditItemInListEmployee(this IList<IWebElement> list, string findIntem, string editItem)
        {
            foreach (IWebElement we in list)
            {
                if (we.Text.Equals(findIntem))
                {
                    Actions ac = new Actions(Driver.driver);
                    ac.MoveToElement(we).Build().Perform();
                    we.Click();
                    //we.SendKeys(editItem);
                    var executor = Driver.driver as IJavaScriptExecutor;
                    executor.ExecuteScript("arguments[0].innerHTML = 'editItem'", we);
                }
            }
        }


        public static void ClickOnElement(IWebElement element)
        {
            IJavaScriptExecutor executor = Driver.driver as IJavaScriptExecutor;
            executor.ExecuteScript("arguments[0].click();", element);
        }

        public static void ScroleToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver.driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public static void OdabirDatumaIzKalendara(IList<IWebElement> kalendar, int trazeniDatum)
        {
            //int _datum = DateTime.Now.Day+1;
            int _datum = trazeniDatum;

            foreach (IWebElement datum in kalendar)
            {
                if (datum.Text.Equals(_datum.ToString()))
                {
                    datum.Click();
                    break;
                }
            }
        }

        public static void OdabirVremenaIzListe(IList<IWebElement> listVreme, string odredjenoVreme)
        {
            foreach (IWebElement _vreme in listVreme)
            {
                if (_vreme.Text.Equals(odredjenoVreme))
                {
                    _vreme.Click();
                    break;
                }
            }
        }
    }
}
