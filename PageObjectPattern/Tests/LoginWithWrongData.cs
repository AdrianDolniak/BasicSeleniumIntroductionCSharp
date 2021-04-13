using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace ProjectSeleniumPOM
{
    [TestClass]
    public class LoginWithWrongData
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void AddNewUserAndLoginTest()
        {
            var login = new LoginPage(driver);
            var start = new TestBase(driver);
            var stop = new TestBase(driver);
            start.Start();
            login.Login("adrian", "12345");
            Thread.Sleep(3000);
            IWebElement isUserNotLogged = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]"));
            Assert.AreEqual("Username or password is incorrect", isUserNotLogged.Text);
            stop.Stop();
        }
    }
}