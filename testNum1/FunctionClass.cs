using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace testNum1
{
    class FunctionClass
    {
        IWebDriver browser;

        public void openChrome()
        {
            browser = new ChromeDriver();
        }

        public void maxiChrome()
        {
            browser.Manage().Window.Maximize();
        }

        public void closeChrome()
        {
            browser.Close();
        }

        public void goToURL(string url)
        {
            browser.Navigate().GoToUrl(url);
        }

        public void insertDataToInputByID(string att, string str)
        {
            browser.FindElement(By.Id(att)).SendKeys(str);
        }

        public void insertDataToInputByClass(string att, string str)
        {
            browser.FindElement(By.ClassName(att)).SendKeys(str);
        }
        public void clickOnElement(string att)
        {
            browser.FindElement(By.XPath("//input[@" + att + "]")).Click();
        }
        public void waitFunc(int time)
        {
            browser.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(time));
        }
    }
}
