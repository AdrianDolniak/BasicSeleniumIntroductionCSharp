// <copyright file="HomePage.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM25Inheritance
{
    using System;
    using System.Threading;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    /// <summary>
    /// HomePage class.
    /// </summary>
    public class HomePage : TestBase
    {
        private static IWebElement Signin => Driver.FindElement(By.ClassName("login"));

        private static IWebElement Signout => Driver.FindElement(By.ClassName("logout"));

        /// <summary>
        /// Metoda SignIn.
        /// </summary>
        public static void SignIn()
        {
           Signin.Click();
        }

        /// <summary>
        /// Metoda SignOut.
        /// </summary>
        public static void SignOut()
        {
            Signout.Click();
        }
    }
}