// <copyright file="Exercise8.cs" company="AD">
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
    public class Exercise8
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

            // Zebranie listy elementów (liczba elementów + pierwszy element + asercja)
            IList<IWebElement> elements = driver.FindElements(By.XPath("//*[@id='content']/div/ul/li"));
            Console.WriteLine("Number of elements:" + elements.Count());
            Console.WriteLine("Text of first elements:" + elements[0].Text);
            Assert.AreEqual("200", elements[0].Text);

            // Zamkniecie przegladarki
            driver.Quit();
        }
    }
}