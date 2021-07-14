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

            // add item to cart
            var orderPage = new OrderPage(Driver);
            orderPage.ClickOnTileTShirts();
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            IWebElement cross = Driver.FindElement(By.ClassName("cross"));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.ClassName("cross")));

            // assert if order is in the cart
            IWebElement isincart = Driver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/h2/span[2]"));
            Assert.AreEqual("There is 1 item in your cart.", isincart.Text);
            Console.WriteLine("Expected: There is 1 item in your cart. \nActual: {0}", isincart.Text);
            cross.Click();
            homePage.SignOut();
        }
    }
}