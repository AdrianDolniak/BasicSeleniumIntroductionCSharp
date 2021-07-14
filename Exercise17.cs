// <copyright file="Exercise17.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace UnitTestProjectSelenium
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Support.UI;

    /// <summary>
    /// Exercise15 class.
    /// </summary>
    public class Exercise17
    {
        /// <summary>
        /// Metoda testowa SampleTestChromeMethod.
        /// </summary>
        [Test]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("http://www.globalsqa.com/angularJs-protractor/registration-login-example/#/login");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Rejestracja
            IWebElement register = driver.FindElement(By.CssSelector("a[href='#/register']"));
            register.Click();
            IWebElement fName = driver.FindElement(By.Id("firstName"));
            fName.SendKeys("Adrian");
            IWebElement lName = driver.FindElement(By.Id("Text1"));
            lName.SendKeys("Dolniak");
            IWebElement uName = driver.FindElement(By.Id("username"));
            uName.SendKeys("adriandolniak");
            IWebElement pass = driver.FindElement(By.Id("password"));
            pass.SendKeys("1234");
            IWebElement submit = driver.FindElement(By.ClassName("form-actions"));
            submit.Submit();
            Thread.Sleep(5000);

            // Logowanie
            IWebElement uNameLog = driver.FindElement(By.Id("username"));
            uNameLog.SendKeys("adriandolniak");
            IWebElement passLog = driver.FindElement(By.Id("password"));
            passLog.SendKeys("1234");
            IWebElement submitLog = driver.FindElement(By.ClassName("form-actions"));
            submitLog.Submit();
            Thread.Sleep(5000);

            // Asercja
            IWebElement isUser = driver.FindElement(By.XPath("//*[contains(text(),'adriandolniak')]"));
            Assert.AreEqual("adriandolniak (Adrian Dolniak) - Delete", isUser.Text);

            // Wylogowanie
            IWebElement loguot = driver.FindElement(By.CssSelector("a[href='#/login']"));
            loguot.Click();

            // Zamkniecie przegladarki
            driver.Quit();
        }
    }
}