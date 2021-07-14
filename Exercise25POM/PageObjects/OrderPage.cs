// <copyright file="OrderPage.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM25
{
    using System;
    using System.Threading;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Interactions;

    /// <summary>
    /// AccountPage class.
    /// </summary>
    public class OrderPage : PageBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderPage"/> class.
        /// Creating a constructor, using a constructor from the PageBase class.
        /// </summary>
        /// <param name="driver">Driver.</param>
        public OrderPage(IWebDriver driver)
    : base(driver) { }

        private IWebElement WomenTile => this.Driver.FindElement(By.CssSelector("#block_top_menu > ul > li:nth-child(1) > a"));

        private IWebElement DressesTile => this.Driver.FindElement(By.CssSelector("#block_top_menu > ul > li:nth-child(2) > a"));

        private IWebElement TShirtsTile => this.Driver.FindElement(By.CssSelector("#block_top_menu > ul > li:nth-child(3) > a"));

        private IWebElement Proceedtocheckout => this.Driver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/a/span"));

        private IWebElement Proceedtocheckoutsummary => this.Driver.FindElement(By.XPath("//*[@id='center_column']/p[2]/a[1]/span"));

        private IWebElement Proceedtocheckoutaddress => this.Driver.FindElement(By.XPath("//*[@id='center_column']/form/p/button/span"));

        private IWebElement Checkbox => this.Driver.FindElement(By.ClassName("checker"));

        private IWebElement Proceedtocheckoutshipping => this.Driver.FindElement(By.XPath("//*[@id='form']/p/button/span"));

        private IWebElement Paybybankwire => this.Driver.FindElement(By.ClassName("bankwire"));

        private IWebElement Orderconfirm => this.Driver.FindElement(By.XPath("//*[@id='cart_navigation']/button/span"));

        private IWebElement Quickview => this.Driver.FindElement(By.XPath("//*[@id='center_column']/ul/li"));

        private IWebElement Addtocart => this.Driver.FindElement(By.XPath("//*[@id='center_column']/ul/li/div/div[2]/div[2]/a[1]/span"));

        /// <summary>
        /// Metoda ClickOnTileWoman.
        /// </summary>
        public void ClickOnTileWoman()
        {
            this.WomenTile.Click();
        }

        /// <summary>
        /// Metoda ClickOnTileDresses.
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
            Actions builder = new Actions(this.Driver);
            builder.MoveToElement(this.Quickview).Perform();
            builder.MoveToElement(this.Addtocart).Click().Perform();
        }

        /// <summary>
        /// Metoda CheckoutProcess.
        /// </summary>
        public void CheckoutProcess()
        {
            this.Proceedtocheckout.Click();
            this.Proceedtocheckoutsummary.Click();
            this.Proceedtocheckoutaddress.Click();
            this.Checkbox.Click();
            this.Proceedtocheckoutshipping.Click();
            this.Paybybankwire.Click();
            this.Orderconfirm.Click();
        }
    }
}