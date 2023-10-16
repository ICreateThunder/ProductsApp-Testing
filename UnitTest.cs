using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApp_Testing
{
    [TestClass]
    public class UnitTest
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new EdgeDriver();
        }

        [Test]
        public void test_Product_Create_Form()
        {
            driver.Url = "https://localhost:44334/";

            driver.Navigate().GoToUrl("https://localhost:44334/Product/Create");

            driver.Manage().Window.Maximize();

            IWebElement FeedCreate = driver.FindElement(By.XPath("/html/body/div/h2"));
            string text = FeedCreate.Text;

            NUnit.Framework.Assert.AreEqual("Create", text);
            System.Threading.Thread.Sleep(500);
            driver.Navigate().Back();
            System.Threading.Thread.Sleep(5000);
        }
    }
}
