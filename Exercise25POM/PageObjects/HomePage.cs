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
    public class HomePage : PageBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HomePage"/> class.
        /// Creating a constructor, using a constructor from the PageBase class.
        /// </summary>
        /// <param name="driver">Driver.</param>
        public HomePage(IWebDriver driver)
    : base(driver) { }

        private IWebElement Signin => this.Driver.FindElement(By.ClassName("login"));

        private IWebElement Signout => this.Driver.FindElement(By.ClassName("logout"));

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