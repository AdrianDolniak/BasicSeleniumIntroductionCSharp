// <copyright file="PlaceOrder.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM25
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Support.UI;
    using Assert = NUnit.Framework.Assert;

    /// <summary>
    /// PlaceOrder class.
    /// </summary>
    [TestClass]
    public class PlaceOrder
    {
        private IWebDriver driver = new ChromeDriver();

        /// <summary>
        /// Metoda testowa PlaceOrderTest.
        /// </summary>
        [Test]
        public void PlaceOrderTest()
        {
        }
    }
}