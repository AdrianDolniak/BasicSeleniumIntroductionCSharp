// <copyright file="OrderPage.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM25
{
    using System;
    using System.Linq;
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
            : base(driver)
        {
        }

        private IWebElement WomenTile => this.Driver.FindElement(By.CssSelector("a[title='Women']"));

        private IWebElement DressesTile => this.Driver.FindElement(By.CssSelector("#block_top_menu>ul>li:nth-child(2)>a"));

        private IWebElement TShirtsTile => this.Driver.FindElement(By.CssSelector("#block_top_menu>ul>li:nth-child(3)>a"));

        private IWebElement Proceedtocheckout => this.Driver.FindElement(By.CssSelector("a[title='Proceed to checkout']"));

        private IWebElement Proceedtocheckoutsummary => this.Driver.FindElement(By.CssSelector("a[title='Proceed to checkout'][class='button btn btn-default standard-checkout button-medium']"));

        private IWebElement Proceedtocheckoutaddress => this.Driver.FindElement(By.CssSelector("[name='processAddress']"));

        private IWebElement Checkbox => this.Driver.FindElement(By.ClassName("checker"));

        private IWebElement Proceedtocheckoutshipping => this.Driver.FindElement(By.CssSelector("[name='processCarrier']"));

        private IWebElement Paybybankwire => this.Driver.FindElement(By.ClassName("bankwire"));

        private IWebElement Orderconfirm => this.Driver.FindElement(By.CssSelector("button[type='submit'][class='button btn btn-default button-medium']"));

        private IWebElement Quickview => this.Driver.FindElement(By.CssSelector("[class='product_list grid row']>li"));

        private IWebElement Addtocart => this.Driver.FindElement(By.CssSelector("a[title='Add to cart'][data-id-product='1']"));

        private IWebElement Isincart => this.Driver.FindElement(By.CssSelector("span[class='ajax_cart_product_txt ']"));

        private IWebElement Ordercomplete => this.Driver.FindElement(By.ClassName("cheque-indent"));

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

        /// <summary>
        /// Metoda IsInCart.
        /// </summary>
        /// <returns>Returns text.</returns>
        public string IsInCart()
        {
            var isincart = this.Isincart.Text;
            return isincart;
        }

        /// <summary>
        /// Metoda OrderComplete.
        /// </summary>
        /// <returns>Returns text.</returns>
        public string OrderComplete()
        {
            var ordercomplete = this.Ordercomplete.Text;
            return ordercomplete;
        }
    }
}