// <copyright file="AddNewUser.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM24Inheritance
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
    public class AddNewUser : TestBase
    {
        /// <summary>
        /// Metoda testowa AddNewUserTest.
        /// </summary>
        [Test]
        public void AddNewUserTest()
        {
            LoginPage.GoToRegisterPage();
            RegisterPage.CreateNewUser("Adrian", "Dolniak", "adolniak", "12345");
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Wait.Until(d => d.Url.Equals("https://www.globalsqa.com/angularJs-protractor/registration-login-example/#/login"));
            IWebElement isUser = Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]"));
            Assert.AreEqual("Registration successful", isUser.Text);
            Stop();
        }
    }
}