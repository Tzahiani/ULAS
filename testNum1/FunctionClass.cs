using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using Newtonsoft.Json.Linq;
using System.Net;

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
            browser.FindElement(By.Id(att)).Clear();
            browser.FindElement(By.Id(att)).SendKeys(str);
        }

        public void insertDataToInputByClass(string att, string str)
        {
            browser.FindElement(By.ClassName(att)).Clear();
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

        public void insertDataToInputByName(string att, string str)
        {
            browser.FindElement(By.Name(att)).Clear();
            browser.FindElement(By.Name(att)).SendKeys(str);
        }

        public string getDataFromJSON(string name, string att)
        {
            string returnAtt=null;

            var json = new WebClient().DownloadString("https://api.magicthegathering.io/v1/cards?name=" + name);
            waitFunc(10);
            JObject obj = JObject.Parse(json);

            returnAtt = obj["cards"][0][att].Value<string>();


            return returnAtt;
        }

        public void clickOnElementByClass(string att)
        {
            browser.FindElement(By.XPath("//span[@" + att + "]")).Click();
        }
    }
}
