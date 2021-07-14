// <copyright file="Exercise12.cs" company="AD">
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
    public class Exercise12
    {
        /// <summary>
        /// Metoda testowa SampleTestChromeMethod.
        /// </summary>
        [Test]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/status_codes");

            // Lokalizacja elementu 200
            IWebElement element = driver.FindElement(By.CssSelector("a[href='status_codes/200']"));
            element.Click();

            // Pobranie tekstu ze strony
            IWebElement text = driver.FindElement(By.CssSelector("#content>div"));
            Console.WriteLine(text.Text);

            // Assercja
            Assert.AreEqual("Status Codes\r\nThis page returned a 200 status code.\r\n\r\nFor a definition and common list of HTTP status codes, go here", text.Text);

            // Zamkniecie przegladarki
            driver.Quit();
        }
    }
}