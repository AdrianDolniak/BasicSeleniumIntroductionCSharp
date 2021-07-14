// <copyright file="CreateNewAcount.cs" company="AD">
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
    /// CreateNewAcount class.
    /// </summary>
    public class CreateNewAcount : TestBase
    {
        /// <summary>
        /// Metoda testowa CreateNewAcountTest.
        /// </summary>
        [Test]
        public void CreateNewAcountTest()
        {
            // register user
            int randomInt = RandomGenerator.Next(10000);
            var homePage = new HomePage(Driver);
            homePage.SignIn();
            var loginPage = new LoginPage(Driver);
            loginPage.GoToRegisterPage("username" + randomInt + "@gmail.com");
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Url.Equals("http://automationpractice.com/index.php?controller=authentication&back=my-account#account-creation"));
            var registerPage = new RegisterPage(Driver);
            registerPage.CreateNewUser("Adam", "Nowak", "12345", "1", "January", "2000", "somestreet", "somecity", "Texas", "11111", "United States", "123-456-789");
            wait.Until(d => d.Url.Equals("http://automationpractice.com/index.php?controller=my-account"));

            // asserst if user is registered
            IWebElement isUser = Driver.FindElement(By.ClassName("account"));
            Assert.AreEqual("Adam Nowak", isUser.Text);
            homePage.SignOut();
        }
    }
}