// <copyright file="AddProductToCart.cs" company="AD">
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
    /// AddProductToCart class.
    /// </summary>
    [TestClass]
    public class AddProductToCart
    {
        private IWebDriver driver = new ChromeDriver();
        private Random randomGenerator = new Random();

        /// <summary>
        /// Metoda testowa AddProductToCartTest.
        /// </summary>
        [Test]
        public void AddProductToCartTest()
        {
            var start = new TestBase(this.driver);
            var stop = new TestBase(this.driver);
            var signin = new HomePage(this.driver);
            var signout = new HomePage(this.driver);
            var createEmail = new LoginPage(this.driver);
            var createNewUser = new RegisterPage(this.driver);
            var clickTitle = new AccountPage(this.driver);
            int randomInt = this.randomGenerator.Next(1000);
            start.Start("http://automationpractice.com/index.php");
            signin.SignIn();
            createEmail.GoToRegisterPage("username" + randomInt + "@gmail.com");
            WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Url.Equals("http://automationpractice.com/index.php?controller=authentication&back=my-account#account-creation"));
            createNewUser.CreateNewUser("Adam", "Nowak", "12345", "1", "January", "2000", "somestreet", "somecity", "Texas", "11111", "United States", "123-456-789");
            wait.Until(d => d.Url.Equals("http://automationpractice.com/index.php?controller=my-account"));
            IWebElement isUser = this.driver.FindElement(By.ClassName("account"));
            Assert.AreEqual("Adam Nowak", isUser.Text);
            clickTitle.AddToCart();

            // signout.SignOut();
            // stop.Stop();
        }
    }
}