// <copyright file="Exercise12.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace UnitTestProjectSelenium
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Support.UI;

    /// <summary>
    /// Exercise15 class.
    /// </summary>
    [TestClass]
    public class Exercise12
    {
        /// <summary>
        /// Metoda testowa SampleTestChromeMethod.
        /// </summary>
        [TestMethod]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/status_codes");

            // Lokalizacja elementu 200
            IWebElement element = driver.FindElement(By.XPath("//*[@id='content']/div/ul/li[1]/a"));
            element.Click();

            // Pobranie tekstu ze strony
            IWebElement text = driver.FindElement(By.CssSelector("#content > div > h3"));
            Console.WriteLine(text.Text);

            // Assercja
            Assert.AreEqual("Status Codes", text.Text);

            // Zamkniecie przegladarki
            driver.Quit();
        }
    }
}