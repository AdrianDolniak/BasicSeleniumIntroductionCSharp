// <copyright file="AddNewUser.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM24
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Support.UI;
    using Assert = NUnit.Framework.Assert;

    /// <summary>
    /// AddNewUser class.
    /// </summary>
    [TestClass]
    public class AddNewUser
    {
        private IWebDriver driver = new ChromeDriver();

        /// <summary>
        /// Metoda testowa AddNewUserTest.
        /// </summary>
        [Test]
        public void AddNewUserTest()
        {
            var login = new LoginPage(this.driver);
            var register = new RegisterPage(this.driver);
            var start = new TestBase(this.driver);
            var stop = new TestBase(this.driver);
            start.Start("https://www.globalsqa.com/angularJs-protractor/registration-login-example/#/login");
            login.GoToRegisterPage();
            register.CreateNewUser("Adrian", "Dolniak", "adolniak", "12345");
            WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Url.Equals("https://www.globalsqa.com/angularJs-protractor/registration-login-example/#/login"));
            IWebElement isUser = this.driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]"));
            Assert.AreEqual("Registration successful", isUser.Text);
            stop.Stop();
        }
    }
}