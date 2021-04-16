// <copyright file="AddNewUserAndLogin.cs" company="AD">
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
    /// AddNewUserAndLogin class.
    /// </summary>
    [TestClass]
    public class AddNewUserAndLogin
    {
        private IWebDriver driver = new ChromeDriver();

        /// <summary>
        /// Metoda testowa AddNewUserAndLoginTest.
        /// </summary>
        [Test]
        public void AddNewUserAndLoginTest()
        {
            var login = new LoginPage(this.driver);
            var register = new RegisterPage(this.driver);
            var start = new TestBase(this.driver);
            var stop = new TestBase(this.driver);
            start.Start("https://www.globalsqa.com/angularJs-protractor/registration-login-example/#/login");
            WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
            login.GoToRegisterPage();
            register.CreateNewUser("Adrian", "Dolniak", "adolniak", "12345");
            wait.Until(d => d.Url.Equals("https://www.globalsqa.com/angularJs-protractor/registration-login-example/#/login"));
            login.Login("adolniak", "12345");
            IWebElement isUserLogged = this.driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/h1"));
            Assert.AreEqual("Hi Adrian!", isUserLogged.Text);
            wait.Until(d => d.Url.Equals("https://www.globalsqa.com/angularJs-protractor/registration-login-example/#/"));
            login.LogOut();
            stop.Stop();
        }
    }
}