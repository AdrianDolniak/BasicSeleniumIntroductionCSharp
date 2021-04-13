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
        [SetUp]
        public void Start()
        {
            driver.Url = "https://www.globalsqa.com/angularJs-protractor/registration-login-example/#/login";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        [Test]
        public void AddNewUserTest()
        { 
            var login = new LoginPage(driver);
            var register = new RegisterPage(driver);
            login.GoToRegisterPage();
            register.CreateNewUser("Adrian", "Dolniak", "adolniak", "12345");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Url.Equals("https://www.globalsqa.com/angularJs-protractor/registration-login-example/#/login"));
            IWebElement isUser = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]"));
            Assert.AreEqual("Registration successful", isUser.Text);
        }
        [TearDown]
        public void Stop()
        {
            driver.Quit();
        }
    }
}