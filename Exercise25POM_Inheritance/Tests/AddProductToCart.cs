// <copyright file="AddProductToCart.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM25Inheritance
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
    public class AddProductToCart : TestBase
    {
        /// <summary>
        /// Metoda testowa AddProductToCartTest.
        /// </summary>
        [Test]
        public void AddProductToCartTest()
        {
            int randomInt = RandomGenerator.Next(10000);
            HomePage.SignIn();
            LoginPage.GoToRegisterPage("username" + randomInt + "@gmail.com");
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Url.Equals("http://automationpractice.com/index.php?controller=authentication&back=my-account#account-creation"));
            RegisterPage.CreateNewUser("Adam", "Nowak", "12345", "1", "January", "2000", "somestreet", "somecity", "Texas", "11111", "United States", "123-456-789");
            wait.Until(d => d.Url.Equals("http://automationpractice.com/index.php?controller=my-account"));
            IWebElement isUser = Driver.FindElement(By.ClassName("account"));
            Assert.AreEqual("Adam Nowak", isUser.Text);
            OrderPage.ClickOnTileTShirts();

            // add item to cart
            Actions builder = new Actions(Driver);
            IWebElement quickview = Driver.FindElement(By.XPath("//*[@id='center_column']/ul/li"));
            IWebElement addtocart = Driver.FindElement(By.XPath("//*[@id='center_column']/ul/li/div/div[2]/div[2]/a[1]/span"));
            builder.MoveToElement(quickview).Perform();
            builder.MoveToElement(addtocart).Click().Perform();
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            IWebElement cross = Driver.FindElement(By.ClassName("cross"));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.ClassName("cross")));
            IWebElement isincart = Driver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/h2/span[2]"));

            // assert if order is in the cart
            Assert.AreEqual("There is 1 item in your cart.", isincart.Text);
            Console.WriteLine("Expected: There is 1 item in your cart. \nActual: {0}", isincart.Text);
            cross.Click();
            HomePage.SignOut();
        }
    }
}