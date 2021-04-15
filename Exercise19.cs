// <copyright file="Exercise19.cs" company="AD">
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
    public class Exercise19
    {
        /// <summary>
        /// Metoda testowa SampleTestChromeMethod.
        /// </summary>
        [TestMethod]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Get page title using JavaScriptExecutor
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            string titleName = js.ExecuteScript("return document.title;").ToString();
            Console.WriteLine("Title of the page = " + titleName);

            // Zamkniecie przegladarki
            driver.Quit();
        }
    }
}