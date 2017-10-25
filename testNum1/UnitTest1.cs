using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.Remoting.Messaging;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net;

namespace testNum1
{
    [TestClass]
    public class UnitTest1
    {
        //IWebDriver browser;
        FunctionClass ff = new FunctionClass();
        [TestMethod]
        public void TestMethod1()
        {
            ff.openChrome();
            ff.maxiChrome();
            ff.goToURL("https://signin.ebay.com/ws/eBayISAPI.dll?SignIn&ru=https%3A%2F%2Fwww.ebay.com%2F");
            ff.insertDataToInputByID("userid", "tanidgar@gmail.com");
            ff.insertDataToInputByID("pass", "Aa15061986");
            ff.clickOnElement("id='sgnBt'");
            ff.waitFunc(10);
            ff.goToURL("http://bulksell.ebay.com/ws/eBayISAPI.dll?SingleList&&DraftURL=http://www.ebay.com/sh/lst/drafts&sellingMode=AddItem&templateId=5202621013&returnUrl=http://bulksell.ebay.com/ws/eBayISAPI.dll?SingleList");
            
            var json = new WebClient().DownloadString("https://api.magicthegathering.io/v1/cards?name=Abrade");
            ff.waitFunc(10);
            JObject obj = JObject.Parse(json);
            string name = obj["cards"][0]["name"].Value<string>();

            ff.insertDataToInputByID("editpane_title", "***4X " + name + "***");
            //ff.insertDataToInputByClass("find-product","Abrade");
            //ff.closeChrome();
        }
    }
}