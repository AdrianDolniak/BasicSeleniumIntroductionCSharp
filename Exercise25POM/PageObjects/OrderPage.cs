// <copyright file="OrderPage.cs" company="AD">
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
    public class OrderPage
    {
        private IWebDriver driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderPage"/> class.
        /// </summary>
        /// <param name="driver">The first name to join.</param>
        public OrderPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement WomenTile => this.driver.FindElement(By.CssSelector("#block_top_menu > ul > li:nth-child(1) > a"));

        private IWebElement DressesTile => this.driver.FindElement(By.CssSelector("#block_top_menu > ul > li:nth-child(2) > a"));

        private IWebElement TShirtsTile => this.driver.FindElement(By.CssSelector("#block_top_menu > ul > li:nth-child(3) > a"));

        /// <summary>
        /// Metoda ClickOnTileWoman.
        /// </summary>
        public void ClickOnTileWoman()
        {
            this.WomenTile.Click();
        }

        /// <summary>
        /// Metoda ClickOnTileWoman.
        /// </summary>
        public void ClickOnTileDresses()
        {
            this.DressesTile.Click();
        }

        /// <summary>
        /// Metoda ClickOnTileTShirts.
        /// </summary>
        public void ClickOnTileTShirts()
        {
            this.TShirtsTile.Click();
        }
    }
}