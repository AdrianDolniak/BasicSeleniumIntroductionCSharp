// <copyright file="Exercise23.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace UnitTestProjectSelenium
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Support.UI;

    /// <summary>
    /// Exercise23 class.
    /// </summary>
    [TestClass]
    public class Exercise23
    {
        /// <summary>
        /// Metoda testowa SampleTestChromeMethod.
        /// </summary>
        [TestMethod]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("https://demos.telerik.com/kendo-ui/dragdrop/index");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Actions class method to drag and drop
            Actions actions = new Actions(driver);
            IWebElement from = driver.FindElement(By.Id("draggable"));
            IWebElement to = driver.FindElement(By.Id("droptarget"));

            // Perform drag and drop
            actions.DragAndDrop(from, to).Perform();

            // Verify text changed in to 'You did great!' box
            string textTo = to.Text;
            if (textTo.Equals("You did great!"))
            {
                Console.WriteLine("PASS: Source is dropped to target as expected");
            }
            else
            {
                Console.WriteLine("FAIL: Source couldn't be dropped to target as expected");
            }

            Assert.AreEqual(textTo, "You did great!");
            Thread.Sleep(3000);

            // Zamkniecie przegladarki
            driver.Quit();
        }
    }
}