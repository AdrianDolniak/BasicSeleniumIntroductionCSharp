// <copyright file="CreateNewAcount.cs" company="AD">
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
    /// CreateNewAcount class.
    /// </summary>
    [TestClass]
    public class CreateNewAcount : TestBase
    {
        /// <summary>
        /// Metoda testowa CreateNewAcountTest.
        /// </summary>
        [Test]
        public void CreateNewAcountTest()
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
          HomePage.SignOut();
        }
    }
}