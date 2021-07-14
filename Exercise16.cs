// <copyright file="Exercise16.cs" company="AD">
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
    /// Exercise16 class.
    /// </summary>
    public class Exercise16
    {
        /// <summary>
        /// Metoda testowa SampleTestChromeMethod.
        /// </summary>
        [Test]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dynamic_loading/1");

            // Lokalizacja elementu i click
            IWebElement start = driver.FindElement(By.XPath("//*[@id='start']/button"));
            start.Click();

            // Explicity wait na załadowanie napisu
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.XPath("//*[@id='loading' and @style='display: none;']")));

            // Asercja
            IWebElement finish = driver.FindElement(By.XPath("//*[@id='finish']/h4"));
            Assert.AreEqual("Hello World!", finish.Text);

            // Zamkniecie przegladarki
            driver.Quit();
        }
    }
}