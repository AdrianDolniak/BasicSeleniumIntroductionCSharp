// <copyright file="AddProductToCart.cs" company="AD">
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
    public class AddProductToCart : TestBase
    {
        /// <summary>
        /// Metoda testowa AddProductToCartTest.
        /// </summary>
        [Test]
        public void AddProductToCartTest()
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

            // add item to cart
            var orderPage = new OrderPage(Driver);
            orderPage.ClickOnTileTShirts();
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            IWebElement cross = Driver.FindElement(By.ClassName("cross"));
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.ClassName("cross")));

            // assert if order is in the cart
            Assert.AreEqual("There is 1 item in your cart.", orderPage.IsInCart());
            Console.WriteLine("Expected: There is 1 item in your cart. \nActual: {0}", orderPage.IsInCart());
            cross.Click();
            homePage.SignOut();
        }
    }
}