// <copyright file="AddNewUser.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM24
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
    /// AddNewUser class.
    /// </summary>
    public class AddNewUser : TestBase
    {
        /// <summary>
        /// Metoda testowa AddNewUserTest.
        /// </summary>
        [Test]
        public void AddNewUserTest()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.GoToRegisterPage();
            var registerPage = new RegisterPage(Driver);
            registerPage.CreateNewUser("Adrian", "Dolniak", "adolniak", "12345");
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Wait.Until(
                d => d.Url.Equals("https://www.globalsqa.com/angularJs-protractor/registration-login-example/#/login"));
            Assert.AreEqual("Registration successful", registerPage.RegistrationSuccessful());
            Stop();
        }
    }
}