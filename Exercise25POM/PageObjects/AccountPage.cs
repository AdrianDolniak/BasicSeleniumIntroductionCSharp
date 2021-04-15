// <copyright file="AccountPage.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM25
{
    using System;
    using System.Threading;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    /// <summary>
    /// AccountPage class.
    /// </summary>
    public class AccountPage
    {
        private IWebDriver driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountPage"/> class.
        /// </summary>
        /// <param name="driver">The first name to join.</param>
        public AccountPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement CatTitle => this.driver.FindElement(By.CssSelector("#block_top_menu > ul > li:nth-child(3) > a"));

        /// <summary>
        /// Metoda AddToCart.
        /// </summary>
        public void AddToCart()
        {
            this.CatTitle.Click();
        }
    }
}