using System;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Drawing;

namespace rwilson.Tests
{
   
    public class QuarkWorkFlow
    {
        
        IWebDriver ieDriver = new InternetExplorerDriver();
        TestUtility utility = new TestUtility();

        [TestMethod]
        public void TestMethod1()
        {
            ieDriver.Manage().Timeouts().SetScriptTimeout(System.TimeSpan.MinValue);
            ieDriver.Manage().Window.Maximize();
            ieDriver.Url = "https://xxxxx.xxxx.com";

            IWebElement query = utility.WaitFindById("logonEmailStatic", ieDriver);
            query.SendKeys("xxxx@xxxx.com");

            IWebElement pWord = utility.WaitFindById("Logon_Password", ieDriver);
            pWord.Clear();
            pWord.SendKeys("xxxxxxx");

            IWebElement subBtnOnLogin = ieDriver.FindElement(By.Id("loginSubmit"));
            subBtnOnLogin.Click();

            IWebElement catalogLink = utility.WaitFindByPartialLinkText("Catalog", ieDriver);
            catalogLink.Click();

            IWebElement product = utility.WaitFindByXpath("//img[contains(@alt,'A4')]", ieDriver);
            product.Click();

            IWebElement createProject = ieDriver.FindElement(By.XPath("//input[@value='Create Project']"));
            createProject.Click();

            IWebElement instantiateProgect = utility.WaitFindByXpath("//input[@id='InstantiateSubmit']", ieDriver);

            IWebElement projectNameField = ieDriver.FindElement(By.XPath("//input[@id='ProjectName']"));
            projectNameField.SendKeys("Project " + DateTime.Now);

            IWebElement docNameField = ieDriver.FindElement(By.XPath("//input[@id='DocumentName']"));
            docNameField.SendKeys("Document " + DateTime.Now);

            instantiateProgect.Click();

            IWebElement editBtn = utility.WaitFindByXpath("//input[@id='Edit']", ieDriver);
            editBtn.Click();

            Thread.Sleep(20000);
           // IMouse.Click(new Point(404, 373));

            IWebElement commentField = utility.WaitFindByXpath("//input[@id='Comments']", ieDriver);
            commentField.SendKeys("Submit Review Comment " + DateTime.Now);

            IWebElement confirmBtn = ieDriver.FindElement(By.XPath("//input[@id='cmdSubmit']"));
            confirmBtn.Click();

            IWebElement reviewBtn = utility.WaitFindByXpath("//input[@id='Review']", ieDriver);
            reviewBtn.Click();


            //Mouse.Click(new Point(404, 373));

            IWebElement extendedReviewBtn = utility.WaitFindByXpath("//input[@id='SubmitforExtended']", ieDriver);
            extendedReviewBtn.Click();

            IWebElement extendedCommentField = utility.WaitFindByXpath("//input[@id='Comments']", ieDriver);
            extendedCommentField.SendKeys("Extended Review Comment " + DateTime.Now);

            IWebElement includeInverstorRelationsCheckBx = ieDriver.FindElement(By.XPath("//input[@id='IncludeInvestorRelations']"));
            includeInverstorRelationsCheckBx.Click();

            IWebElement confirmBtn1 = ieDriver.FindElement(By.XPath("//input[@id='cmdSubmit']"));
            confirmBtn1.Click();

            IWebElement approveBtn = utility.WaitFindByXpath("//input[@id='ReviewApprove']", ieDriver);
            approveBtn.Click();

            IWebElement approveBtn1 = utility.WaitFindByXpath("//input[@id='ReviewApprove']", ieDriver);
            approveBtn1.Click();

            IWebElement OutputBtn = utility.WaitFindByXpath("//input[@id='Output']", ieDriver);
            OutputBtn.Click();

            IWebElement createOutputPop = ieDriver.FindElement(By.XPath("//p[contains(.,'Creating Output....')]"));




            while (createOutputPop.Displayed)
            {
                IWebElement createOutputPop1 = ieDriver.FindElement(By.XPath("//p[contains(.,'Creating Output....')]"));
            }



            IWebElement logOffLink = ieDriver.FindElement(By.PartialLinkText("Log Off"));
            logOffLink.Click();

            ieDriver.Close();

            ieDriver.Dispose();

        }
    }
}

