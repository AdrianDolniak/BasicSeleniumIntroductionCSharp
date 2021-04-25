// <copyright file="LoginPage.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM25Inheritance
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
        private static IWebElement EmailAdressLog => Driver.FindElement(By.Id("email"));

        private static IWebElement PassLog => Driver.FindElement(By.Id("passwd"));

        private static IWebElement SubmitLog => Driver.FindElement(By.Id("SubmitLogin"));

        private static IWebElement EmailAdressReg => Driver.FindElement(By.Id("email_create"));

        private static IWebElement SubmitReg => Driver.FindElement(By.Id("SubmitCreate"));

        /// <summary>
        /// Metoda Login.
        /// </summary>
        /// <param name="emailaddressnamelog">The username.</param>
        /// <param name="passlog">The password.</param>
        public static void Login(string emailaddressnamelog, string passlog)
        {
            EmailAdressLog.SendKeys(emailaddressnamelog);
            PassLog.SendKeys(passlog);
            SubmitLog.Click();
        }

        /// <summary>
        /// Metoda GoToRegisterPage.
        /// </summary>
        /// <param name="emailaddressreg">The username.</param>
        public static void GoToRegisterPage(string emailaddressreg)
        {
            EmailAdressReg.SendKeys(emailaddressreg);
            SubmitReg.Click();
        }
    }
}