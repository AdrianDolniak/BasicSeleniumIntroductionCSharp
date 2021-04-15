// <copyright file="Exercise21.cs" company="AD">
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
    /// Exercise21 class.
    /// </summary>
    [TestClass]
    public class Exercise21
    {
        /// <summary>
        /// Metoda testowa SampleTestChromeMethod.
        /// </summary>
        [TestMethod]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/windows");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Lokalizacja elementu i click
            IWebElement start = driver.FindElement(By.CssSelector("#content > div > a"));
            start.Click();

            // Click link and get title new Tab
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            IWebElement text = driver.FindElement(By.ClassName("example"));
            Console.WriteLine("New tab text:" + text.Text);

            // Back to previusly Tab and get title
            driver.SwitchTo().Window(driver.WindowHandles.FirstOrDefault());
            string titleHome = driver.Title;
            Console.WriteLine("Home tab title:" + titleHome);

            // Zamkniecie przegladarki
            driver.Quit();
        }
    }
}