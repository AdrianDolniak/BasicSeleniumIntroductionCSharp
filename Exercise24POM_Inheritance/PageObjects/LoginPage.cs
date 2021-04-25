// <copyright file="LoginPage.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM24Inheritance
{
    using System;
    using System.Threading;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    /// <summary>
    /// LoginPage class.
    /// </summary>
    public class LoginPage : TestBase
    {
        private static IWebElement UNameLog => Driver.FindElement(By.Id("username"));

        private static IWebElement PassLog => Driver.FindElement(By.Id("password"));

        private static IWebElement SubmitLog => Driver.FindElement(By.ClassName("form-actions"));

        private static IWebElement Register => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/form/div[3]/a"));

        private static IWebElement Loguot => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/p[3]/a"));

        /// <summary>
        /// Metoda Login.
        /// </summary>
        /// <param name="unamelog">The username.</param>
        /// <param name="passlog">The password.</param>
        public static void Login(string unamelog, string passlog)
        {
            UNameLog.SendKeys(unamelog);
            PassLog.SendKeys(passlog);
            SubmitLog.Submit();
        }

        /// <summary>
        /// Metoda LogOut.
        /// </summary>
        public static void LogOut()
        {
            Loguot.Click();
        }

        /// <summary>
        /// Metoda GoToRegisterPage.
        /// </summary>
        public static void GoToRegisterPage()
        {
            Register.Click();
        }
    }
}