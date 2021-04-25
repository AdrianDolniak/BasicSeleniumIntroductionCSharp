// <copyright file="TestBase.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM25Inheritance
{
    using System;
    using System.Linq;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    /// <summary>
    /// TestBase class.
    /// </summary>
    public class TestBase
    {
        /// <summary>
        /// Gets or sets a new instance of Driver.
        /// </summary>
        public static IWebDriver Driver { get; set; }

        /// <summary>
        /// Gets or sets a new instance of Random.
        /// </summary>
        public static Random RandomGenerator { get; set; }

        /// <summary>
        /// Metoda Start.
        /// </summary>
        [SetUp]
        public static void Start()
            {
            Driver = new ChromeDriver();
            RandomGenerator = new Random();
            Driver.Url = "http://automationpractice.com/index.php";
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }

        /// <summary>
        /// Metoda Stop.
        /// </summary>
        [TearDown]
        public static void Stop()
            {
            Driver.Quit();
        }
    }
}