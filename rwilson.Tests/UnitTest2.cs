using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using rwilson.Tests;
using OpenQA.Selenium.Support.PageObjects;

namespace rwilson.Tests
{

    [TestClass]
    public class UnitTest2
    {


        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver chromeDriver = new ChromeDriver();
            home homObj = new home();

            chromeDriver.Navigate().GoToUrl("http://zoll.com");
            
            // aboutUs.Click();
            //aboutZoll1.Click();
            contactUs.Click();

            //  Assert.AreEqual("Contact Us", chromeDriver.FindElement(By.XPath("(//a[contains(text(),'Contact Us')])[4]")).Text);
        }

        [FindsBy(How = How.LinkText, Using = "Contact Us")]
        [CacheLookup]
        private IWebElement contactUs;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(4) a")]
        [CacheLookup]
        public IWebElement aboutUs;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(4) ul.submenu li:nth-of-type(5) a")]
        [CacheLookup]
        public IWebElement aboutZoll1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(4) ul.submenu li:nth-of-type(1) a")]
        [CacheLookup]
        public IWebElement contactUs1;
    }

}


