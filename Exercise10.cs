// <copyright file="Exercise10.cs" company="AD">
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
    public class Exercise10
    {
        /// <summary>
        /// Metoda testowa SampleTestChromeMethod.
        /// </summary>
        [TestMethod]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-checkbox-demo.html");

            // Lokalizacja checkboxa
            IWebElement option_1 = driver.FindElement(By.XPath("//*[@id='easycont']/div/div[2]/div[2]/div[2]/div[1]/label/input"));

            // Click on 1 and 4 checkbox, check if is checked, then click „Check All” and check if all checkboxes are checked
            Thread.Sleep(5000);
            option_1.Click();
            bool option_1_status = option_1.Selected;
            IWebElement option_4 = driver.FindElement(By.XPath("//*[@id='easycont']/div/div[2]/div[2]/div[2]/div[4]/label/input"));
            Thread.Sleep(5000);
            option_4.Click();
            bool option_4_status = option_4.Selected;
            Thread.Sleep(5000);
            IWebElement option_all = driver.FindElement(By.XPath("//*[@id='check1']"));
            option_all.Click();
            IWebElement option_2 = driver.FindElement(By.XPath("//*[@id='easycont']/div/div[2]/div[2]/div[2]/div[2]/label/input"));
            IWebElement option_3 = driver.FindElement(By.XPath("//*[@id='easycont']/div/div[2]/div[2]/div[2]/div[3]/label/input"));
            Thread.Sleep(5000);
            option_1_status = option_1.Selected;
            bool option_2_status = option_2.Selected;
            bool option_3_status = option_3.Selected;
            option_4_status = option_4.Selected;

            // Zamkniecie przegladarki
            driver.Quit();
        }
    }
}