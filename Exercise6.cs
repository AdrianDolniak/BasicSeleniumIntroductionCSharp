// <copyright file="Exercise6.cs" company="AD">
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
    public class Exercise6
    {
        /// <summary>
        /// Metoda testowa SampleTestChromeMethod.
        /// </summary>
        [TestMethod]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/");

            // Lokalizacja pola "Start Practising”
            IWebElement startPractisingID = driver.FindElement(By.Id("btn_basic_example"));
            IWebElement startPractisingCSS = driver.FindElement(By.CssSelector("#btn_basic_example"));
            IWebElement startPractisingXPath = driver.FindElement(By.XPath("//*[@id='btn_basic_example']"));

            // Zamkniecie przegladarki
            driver.Quit();
        }
    }
}