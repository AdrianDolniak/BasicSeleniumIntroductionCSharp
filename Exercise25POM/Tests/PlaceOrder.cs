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

            // place order
            var orderPage = new OrderPage(Driver);
            orderPage.ClickOnTileTShirts();
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            orderPage.CheckoutProcess();

            // assert if order is placed
            Assert.AreEqual("Your order on My Store is complete.", orderPage.OrderComplete());
            Console.WriteLine("Expected: Your order on My Store is complete. \nActual: {0}", orderPage.OrderComplete());
            homePage.SignOut();
        }
    }
}