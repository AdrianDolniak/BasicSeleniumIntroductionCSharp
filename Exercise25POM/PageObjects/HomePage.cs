// <copyright file="HomePage.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM25
{
    using System;
    using System.Threading;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    /// <summary>
    /// HomePage class.
    /// </summary>
    public class HomePage
    {
        private IWebDriver driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomePage"/> class.
        /// </summary>
        /// <param name="driver">The first name to join.</param>
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement Signin => this.driver.FindElement(By.ClassName("login"));

        private IWebElement Signout => this.driver.FindElement(By.ClassName("logout"));

        /// <summary>
        /// Metoda SignIn.
        /// </summary>
        public void SignIn()
        {
            this.Signin.Click();
        }

        /// <summary>
        /// Metoda SignOut.
        /// </summary>
        public void SignOut()
        {
            this.Signout.Click();
        }
    }
}