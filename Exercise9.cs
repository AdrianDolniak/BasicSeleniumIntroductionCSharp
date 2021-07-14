// <copyright file="Exercise9.cs" company="AD">
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
    public class Exercise9
    {
        /// <summary>
        /// Metoda testowa SampleTestChromeMethod.
        /// </summary>
        [Test]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/checkboxes");

            // Lokalizacja checkboxa
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='checkboxes']/input[1]"));

            // Kliknięcie checkboxa
            Thread.Sleep(5000);
            loginButton.Click();
            Thread.Sleep(5000);
            loginButton.Submit();
            Thread.Sleep(5000);

            // Podwójne kliknięcie checkboxa
            Actions action = new Actions(driver);
            IWebElement element = driver.FindElement(By.XPath("//*[@id='checkboxes']/input[1]"));
            action.DoubleClick(element).Perform();

            // Zamkniecie przegladarki
            driver.Quit();
        }
    }
}