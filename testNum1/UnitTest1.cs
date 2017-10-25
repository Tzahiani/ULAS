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

            //get all data we need for a card
            string name = ff.getDataFromJSON("Abrade", "name");
            string set = ff.getDataFromJSON("Abrade", "set");
            string setName = ff.getDataFromJSON("Abrade", "setName"); 

            //Insert To Fileds
            ff.insertDataToInputByName("title", "***4X " + name + "- MTG - " + setName + " - " + set + "***");

            ff.clickOnElementByClass("class='copyWebLink2'");
        }
    }
}