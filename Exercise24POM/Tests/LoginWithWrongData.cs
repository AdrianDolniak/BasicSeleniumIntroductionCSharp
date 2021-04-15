// <copyright file="LoginWithWrongData.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM
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
    /// LoginWithWrongData class.
    /// </summary>
    [TestClass]
    public class LoginWithWrongData
    {
        private IWebDriver driver = new ChromeDriver();

        /// <summary>
        /// Metoda testowa LoginWithWrongDataTest.
        /// </summary>
        [Test]
        public void LoginWithWrongDataTest()
        {
            var login = new LoginPage(this.driver);
            var start = new TestBase(this.driver);
            var stop = new TestBase(this.driver);
            start.Start("https://www.globalsqa.com/angularJs-protractor/registration-login-example/#/login");
            login.Login("adrian", "12345");
            Thread.Sleep(3000);
            IWebElement isUserNotLogged = this.driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]"));
            Assert.AreEqual("Username or password is incorrect", isUserNotLogged.Text);
            stop.Stop();
        }
    }
}