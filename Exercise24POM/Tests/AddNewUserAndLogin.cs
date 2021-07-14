// <copyright file="AddNewUserAndLogin.cs" company="AD">
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
    /// AddNewUserAndLogin class.
    /// </summary>
    public class AddNewUserAndLogin : TestBase
    {
        /// <summary>
        /// Metoda testowa AddNewUserAndLoginTest.
        /// </summary>
        [Test]
        public void AddNewUserAndLoginTest()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.GoToRegisterPage();
            var registerPage = new RegisterPage(Driver);
            registerPage.CreateNewUser("Adrian", "Dolniak", "adolniak", "12345");
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Wait.Until(d => d.Url.Equals("https://www.globalsqa.com/angularJs-protractor/registration-login-example/#/login"));
            loginPage.Login("adolniak", "12345");
            IWebElement isUserLogged = Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/h1"));
            Assert.AreEqual("Hi Adrian!", isUserLogged.Text);
            Wait.Until(d => d.Url.Equals("https://www.globalsqa.com/angularJs-protractor/registration-login-example/#/"));
            loginPage.LogOut();
            Stop();
        }
    }
}