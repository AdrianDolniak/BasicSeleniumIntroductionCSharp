// <copyright file="Exercise18.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace UnitTestProjectSelenium
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
    /// Exercise15 class.
    /// </summary>
    public class Exercise18
    {
        /// <summary>
        /// Metoda testowa SampleTestChromeMethod.
        /// </summary>
        [Test]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/javascript_alerts");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Click one of buttons, handle an event and check result in textbox
            IWebElement alert = driver.FindElement(By.CssSelector("button[onclick='jsAlert()']"));
            alert.Click();
            driver.SwitchTo().Alert().Accept();

            IWebElement result = driver.FindElement(By.CssSelector("#result"));
            Assert.AreEqual("You successfully clicked an alert", result.Text);

            // Zamkniecie przegladarki
            driver.Quit();
        }
    }
}