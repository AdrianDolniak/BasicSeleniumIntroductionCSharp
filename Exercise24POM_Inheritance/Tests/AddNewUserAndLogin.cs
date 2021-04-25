// <copyright file="AddNewUserAndLogin.cs" company="AD">
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
    /// AddNewUserAndLogin class.
    /// </summary>
    [TestClass]
    public class AddNewUserAndLogin : TestBase
    {
        private static WebDriverWait wait;

        /// <summary>
        /// Metoda testowa AddNewUserAndLoginTest.
        /// </summary>
        [Test]
        public void AddNewUserAndLoginTest()
        {
            LoginPage.GoToRegisterPage();
            RegisterPage.CreateNewUser("Adrian", "Dolniak", "adolniak", "12345");
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Url.Equals("https://www.globalsqa.com/angularJs-protractor/registration-login-example/#/login"));
            LoginPage.Login("adolniak", "12345");
            IWebElement isUserLogged = Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/h1"));
            Assert.AreEqual("Hi Adrian!", isUserLogged.Text);
            wait.Until(d => d.Url.Equals("https://www.globalsqa.com/angularJs-protractor/registration-login-example/#/"));
            LoginPage.LogOut();
            Stop();
        }
    }
}