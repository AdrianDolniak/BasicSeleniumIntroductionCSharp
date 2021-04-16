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
            var clickTile = new OrderPage(this.driver);
            int randomInt = this.randomGenerator.Next(10000);
            start.Start("http://automationpractice.com/index.php");
            signin.SignIn();
            createEmail.GoToRegisterPage("username" + randomInt + "@gmail.com");
            WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Url.Equals("http://automationpractice.com/index.php?controller=authentication&back=my-account#account-creation"));
            createNewUser.CreateNewUser("Adam", "Nowak", "12345", "1", "January", "2000", "somestreet", "somecity", "Texas", "11111", "United States", "123-456-789");
            wait.Until(d => d.Url.Equals("http://automationpractice.com/index.php?controller=my-account"));
            IWebElement isUser = this.driver.FindElement(By.ClassName("account"));
            Assert.AreEqual("Adam Nowak", isUser.Text);
            clickTile.ClickOnTileTShirts();

            // add item to cart
            Actions builder = new Actions(this.driver);
            IWebElement quickview = this.driver.FindElement(By.XPath("//*[@id='center_column']/ul/li"));
            IWebElement addtocart = this.driver.FindElement(By.XPath("//*[@id='center_column']/ul/li/div/div[2]/div[2]/a[1]/span"));
            builder.MoveToElement(quickview).Perform();
            builder.MoveToElement(addtocart).Click().Perform();
            this.driver.SwitchTo().Window(this.driver.WindowHandles.Last());
            IWebElement cross = this.driver.FindElement(By.ClassName("cross"));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.ClassName("cross")));
            IWebElement isincart = this.driver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/h2/span[2]"));

            // assert if order is in the cart
            Assert.AreEqual("There is 1 item in your cart.", isincart.Text);
            Console.WriteLine("Expected: There is 1 item in your cart. \nActual: {0}", isincart.Text);
            cross.Click();
            signout.SignOut();
            stop.Stop();
        }
    }
}