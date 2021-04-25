// <copyright file="LogIn.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM25Inheritance
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
    public class LogIn : TestBase
    {
        /// <summary>
        /// Metoda testowa LogInTest.
        /// </summary>
        [Test]
        public void LogInTest()
        {
            // login user
            HomePage.SignIn();
            LoginPage.Login("aaa@ob.pl", "12345");
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Url.Equals("http://automationpractice.com/index.php?controller=my-account"));

            // assert if user is logged
            IWebElement isUser = Driver.FindElement(By.ClassName("account"));
            Assert.AreEqual("ad ad", isUser.Text);
            HomePage.SignOut();
        }
    }
}