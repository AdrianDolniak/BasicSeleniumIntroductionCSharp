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
    public class AddNewUser
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void AddNewUserTest()
        { 
            var login = new LoginPage(driver);
            var register = new RegisterPage(driver);
            var start = new TestBase(driver);
            var stop = new TestBase(driver);
            start.Start();
            login.GoToRegisterPage();
            register.CreateNewUser("Adrian", "Dolniak", "adolniak", "12345");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Url.Equals("https://www.globalsqa.com/angularJs-protractor/registration-login-example/#/login"));
            IWebElement isUser = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]"));
            Assert.AreEqual("Registration successful", isUser.Text);
            stop.Stop();
        }
    }
}