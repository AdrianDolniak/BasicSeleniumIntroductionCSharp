// <copyright file="OrderPage.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM25Inheritance
{
    using System;
    using System.Threading;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    /// <summary>
    /// AccountPage class.
    /// </summary>
    public class OrderPage : TestBase
    {
        private static IWebElement WomenTile => Driver.FindElement(By.CssSelector("#block_top_menu > ul > li:nth-child(1) > a"));

        private static IWebElement DressesTile => Driver.FindElement(By.CssSelector("#block_top_menu > ul > li:nth-child(2) > a"));

        private static IWebElement TShirtsTile => Driver.FindElement(By.CssSelector("#block_top_menu > ul > li:nth-child(3) > a"));

        /// <summary>
        /// Metoda ClickOnTileWoman.
        /// </summary>
        public static void ClickOnTileWoman()
        {
            WomenTile.Click();
        }

        /// <summary>
        /// Metoda ClickOnTileWoman.
        /// </summary>
        public static void ClickOnTileDresses()
        {
            DressesTile.Click();
        }

        /// <summary>
        /// Metoda ClickOnTileTShirts.
        /// </summary>
        public static void ClickOnTileTShirts()
        {
            TShirtsTile.Click();
        }
    }
}