// <copyright file="OrderPage.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM25Inheritance
{
    using System;
    using System.Threading;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Interactions;

    /// <summary>
    /// AccountPage class.
    /// </summary>
    public class OrderPage : TestBase
    {
        private static IWebElement WomenTile => Driver.FindElement(By.CssSelector("#block_top_menu > ul > li:nth-child(1) > a"));

        private static IWebElement DressesTile => Driver.FindElement(By.CssSelector("#block_top_menu > ul > li:nth-child(2) > a"));

        private static IWebElement TShirtsTile => Driver.FindElement(By.CssSelector("#block_top_menu > ul > li:nth-child(3) > a"));

        private static IWebElement Proceedtocheckout => Driver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/a/span"));

        private static IWebElement Proceedtocheckoutsummary => Driver.FindElement(By.XPath("//*[@id='center_column']/p[2]/a[1]/span"));

        private static IWebElement Proceedtocheckoutaddress => Driver.FindElement(By.XPath("//*[@id='center_column']/form/p/button/span"));

        private static IWebElement Checkbox => Driver.FindElement(By.ClassName("checker"));

        private static IWebElement Proceedtocheckoutshipping => Driver.FindElement(By.XPath("//*[@id='form']/p/button/span"));

        private static IWebElement Paybybankwire => Driver.FindElement(By.ClassName("bankwire"));

        private static IWebElement Orderconfirm => Driver.FindElement(By.XPath("//*[@id='cart_navigation']/button/span"));

        private static IWebElement Quickview => Driver.FindElement(By.XPath("//*[@id='center_column']/ul/li"));

        private static IWebElement Addtocart => Driver.FindElement(By.XPath("//*[@id='center_column']/ul/li/div/div[2]/div[2]/a[1]/span"));

        /// <summary>
        /// Metoda ClickOnTileWoman.
        /// </summary>
        public static void ClickOnTileWoman()
        {
            WomenTile.Click();
        }

        /// <summary>
        /// Metoda ClickOnTileDresses.
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
            Actions builder = new Actions(Driver);
            builder.MoveToElement(Quickview).Perform();
            builder.MoveToElement(Addtocart).Click().Perform();
        }

        /// <summary>
        /// Metoda CheckoutProcess.
        /// </summary>
        public static void CheckoutProcess()
        {
            Proceedtocheckout.Click();
            Proceedtocheckoutsummary.Click();
            Proceedtocheckoutaddress.Click();
            Checkbox.Click();
            Proceedtocheckoutshipping.Click();
            Paybybankwire.Click();
            Orderconfirm.Click();
        }
    }
}