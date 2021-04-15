// <copyright file="Exercise22.cs" company="AD">
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
    public class Exercise22
    {
        /// <summary>
        /// Metoda testowa SampleTestChromeMethod.
        /// </summary>
        [TestMethod]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/iframe");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Send some text to iFrame textbox
            driver.SwitchTo().Frame(0);
            IWebElement textBox = driver.FindElement(By.XPath("//*[@id='tinymce']"));
            textBox.Clear();
            textBox.SendKeys("some text");
            Thread.Sleep(3000);

            // Zamkniecie przegladarki
            driver.Quit();
        }
    }
}