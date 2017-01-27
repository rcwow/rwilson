using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace rwilson.Tests
{
    class TestUtility
    {
        public IWebElement WaitFindByXpath(string locale, IWebDriver i)
        {
            WebDriverWait wait2 = new WebDriverWait(i, TimeSpan.FromSeconds(10));
            IWebElement product = wait2.Until<IWebElement>((d) => d.FindElement(By.XPath(locale)
            ));

            return product;
        }

        public IWebElement WaitFindById(string locale, IWebDriver i)
        {
            WebDriverWait wait2 = new WebDriverWait(i, TimeSpan.FromSeconds(15));
            IWebElement product = wait2.Until<IWebElement>((d) => d.FindElement(By.Id(locale)
            ));

            return product;
        }

        public IWebElement WaitFindByPartialLinkText(string locale, IWebDriver i)
        {
            WebDriverWait wait2 = new WebDriverWait(i, TimeSpan.FromSeconds(10));
            IWebElement product = wait2.Until<IWebElement>((d) => d.FindElement(By.PartialLinkText(locale)
            ));

            return product;
        }

    }
}
