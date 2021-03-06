// <copyright file="Exercise7.cs" company="AD">
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
    public class Exercise7
    {
        /// <summary>
        /// Metoda testowa SampleTestChromeMethod.
        /// </summary>
        [Test]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("https://www.linkedin.com/");

            // Lokalizacja pola "Salaries”
            IWebElement startPractisingCSS = driver.FindElement(By.CssSelector("[href='https://www.linkedin.com/salary/?trk=homepage-basic_directory_salaryHomeUrl']"));

            // Zamkniecie przegladarki
            driver.Quit();
        }
    }
}