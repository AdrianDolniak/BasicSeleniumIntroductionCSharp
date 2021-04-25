// <copyright file="TestBase.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM24Inheritance
{
    using System;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;

    /// <summary>
    /// TestBase class.
    /// </summary>
    public class TestBase
    {
        /// <summary>
        /// Gets or sets a new instance of Driver.
        /// </summary>
        public static IWebDriver Driver { get;  set; }

        /// <summary>
        /// Gets or sets a new instance of Wait.
        /// </summary>
        public static WebDriverWait Wait { get; set; }

        /// <summary>
        /// Metoda Start.
        /// </summary>
        [SetUp]
        public static void Start()
            {
            Driver = new ChromeDriver();
            Driver.Url = "https://www.globalsqa.com/angularJs-protractor/registration-login-example/#/login";
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