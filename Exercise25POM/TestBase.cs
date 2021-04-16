// <copyright file="TestBase.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM25
{
    using System;
    using System.Linq;
    using NUnit.Framework;
    using OpenQA.Selenium;

    /// <summary>
    /// TestBase class.
    /// </summary>
    public class TestBase
    {
        private IWebDriver driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="TestBase"/> class.
        /// </summary>
        /// <param name="driver">The first name to join.</param>
        public TestBase(IWebDriver driver)
        {
            this.driver = driver;
        }

        /// <summary>
        /// Metoda Start.
        /// </summary>
        /// <param name="urladdress">The username.</param>
        [SetUp]
        public void Start(string urladdress)
            {
            this.driver.Url = urladdress;
            this.driver.Manage().Window.Maximize();
            this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }

        /// <summary>
        /// Metoda Stop.
        /// </summary>
        [TearDown]
        public void Stop()
            {
            this.driver.Quit();
        }
    }
}