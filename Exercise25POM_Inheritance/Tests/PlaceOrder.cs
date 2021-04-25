// <copyright file="PlaceOrder.cs" company="AD">
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
    public class PlaceOrder : TestBase
    {
        /// <summary>
        /// Metoda testowa AddProductToCartTest.
        /// </summary>
        [Test]
        public void PlaceOrderTest()
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

          // place order
          Actions builder = new Actions(Driver);
          IWebElement quickview = Driver.FindElement(By.XPath("//*[@id='center_column']/ul/li"));
          IWebElement addtocart = Driver.FindElement(By.XPath("//*[@id='center_column']/ul/li/div/div[2]/div[2]/a[1]/span"));
          builder.MoveToElement(quickview).Perform();
          builder.MoveToElement(addtocart).Click().Perform();
          Driver.SwitchTo().Window(Driver.WindowHandles.Last());
          IWebElement proceedtocheckout = Driver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/a/span"));
          proceedtocheckout.Click();
          IWebElement proceedtocheckoutsummary = Driver.FindElement(By.XPath("//*[@id='center_column']/p[2]/a[1]/span"));
          proceedtocheckoutsummary.Click();
          IWebElement proceedtocheckoutaddress = Driver.FindElement(By.XPath("//*[@id='center_column']/form/p/button/span"));
          proceedtocheckoutaddress.Click();
          IWebElement checkbox = Driver.FindElement(By.ClassName("checker"));
          checkbox.Click();
          IWebElement proceedtocheckoutshipping = Driver.FindElement(By.XPath("//*[@id='form']/p/button/span"));
          proceedtocheckoutshipping.Click();
          IWebElement paybybankwire = Driver.FindElement(By.ClassName("bankwire"));
          paybybankwire.Click();
          IWebElement orderconfirm = Driver.FindElement(By.XPath("//*[@id='cart_navigation']/button/span"));
          orderconfirm.Click();
          IWebElement ordercomplete = Driver.FindElement(By.ClassName("cheque-indent"));

          // assert if order is placed
          Assert.AreEqual("Your order on My Store is complete.", ordercomplete.Text);
          Console.WriteLine("Expected: Your order on My Store is complete. \nActual: {0}", ordercomplete.Text);
          HomePage.SignOut();
        }
    }
}