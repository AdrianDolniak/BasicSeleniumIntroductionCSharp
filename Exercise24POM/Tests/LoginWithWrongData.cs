// <copyright file="LoginWithWrongData.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM24
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
    /// LoginWithWrongData class.
    /// </summary>
    public class LoginWithWrongData : TestBase
    {
        /// <summary>
        /// Metoda testowa LoginWithWrongDataTest.
        /// </summary>
        [Test]
        public void LoginWithWrongDataTest()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.Login("adrian", "12345");
            Thread.Sleep(3000);
            IWebElement isUserNotLogged = Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]"));
            Assert.AreEqual("Username or password is incorrect", isUserNotLogged.Text);
            Stop();
        }
    }
}