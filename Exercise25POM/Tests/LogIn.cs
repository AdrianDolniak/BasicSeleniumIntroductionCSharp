// <copyright file="LogIn.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM25
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Support.UI;

    /// <summary>
    /// LogIn class.
    /// </summary>
    public class LogIn : TestBase
    {
        /// <summary>
        /// Metoda testowa LogInTest.
        /// </summary>
        [Test]
        public void LogInTest()
        {
            // login user
            var homePage = new HomePage(Driver);
            homePage.SignIn();
            var loginPage = new LoginPage(Driver);
            loginPage.Login();
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Wait.Until(
                d => d.Url.Equals("http://automationpractice.com/index.php?controller=my-account"));

            // assert if user is logged
            var registerPage = new RegisterPage(Driver);
            Assert.AreEqual("ad ad", registerPage.RegistrationSuccessful());
            homePage.SignOut();
        }
    }
}