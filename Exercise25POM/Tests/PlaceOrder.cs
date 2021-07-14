// <copyright file="PlaceOrder.cs" company="AD">
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
    /// AddProductToCart class.
    /// </summary>
    public class PlaceOrder : TestBase
    {
        /// <summary>
        /// Metoda testowa PlaceOrderTest.
        /// </summary>
        [Test]
        public void PlaceOrderTest()
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
            IWebElement isUser = Driver.FindElement(By.ClassName("account"));
            Assert.AreEqual("Adam Nowak", isUser.Text);

            // place order
            var orderPage = new OrderPage(Driver);
            orderPage.ClickOnTileTShirts();
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            orderPage.CheckoutProcess();

            // assert if order is placed
            IWebElement ordercomplete = Driver.FindElement(By.ClassName("cheque-indent"));
            Assert.AreEqual("Your order on My Store is complete.", ordercomplete.Text);
            Console.WriteLine("Expected: Your order on My Store is complete. \nActual: {0}", ordercomplete.Text);
            homePage.SignOut();
        }
    }
}