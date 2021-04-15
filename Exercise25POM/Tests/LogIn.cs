// <copyright file="LogIn.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM25
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
    /// LogIn class.
    /// </summary>
    [TestClass]
    public class LogIn
    {
        private IWebDriver driver = new ChromeDriver();

        /// <summary>
        /// Metoda testowa LogInTest.
        /// </summary>
        [Test]
        public void LogInTest()
        {
            var start = new TestBase(this.driver);
            var stop = new TestBase(this.driver);
            var signin = new HomePage(this.driver);
            var signout = new HomePage(this.driver);
            var login = new LoginPage(this.driver);
            start.Start("http://automationpractice.com/index.php");
            signin.SignIn();
            login.Login("aaa@ob.pl", "12345");
            WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Url.Equals("http://automationpractice.com/index.php?controller=my-account"));
            IWebElement isUser = this.driver.FindElement(By.ClassName("account"));
            Assert.AreEqual("ad ad", isUser.Text);
            signout.SignOut();
            stop.Stop();
        }
    }
}