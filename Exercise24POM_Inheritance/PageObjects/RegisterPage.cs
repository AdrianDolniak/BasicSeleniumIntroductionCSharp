// <copyright file="RegisterPage.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM24Inheritance
{
    using System;
    using System.Threading;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    /// <summary>
    /// RegisterPage class.
    /// </summary>
    public class RegisterPage : TestBase
    {
        private static IWebElement FName => Driver.FindElement(By.Id("firstName"));

        private static IWebElement LName => Driver.FindElement(By.Id("Text1"));

        private static IWebElement UName => Driver.FindElement(By.Id("username"));

        private static IWebElement Pass => Driver.FindElement(By.Id("password"));

        private static IWebElement Submit => Driver.FindElement(By.ClassName("form-actions"));

        /// <summary>
        /// Metoda CreateNewUser.
        /// </summary>
        /// <param name="fname">The first name.</param>
        /// <param name="lname">The last name.</param>
        /// <param name="uname">The username.</param>
        /// <param name="password">The password.</param>
        public static void CreateNewUser(string fname, string lname, string uname, string password)
        {
            FName.SendKeys(fname);
            LName.SendKeys(lname);
            UName.SendKeys(uname);
            Pass.SendKeys(password);
            Submit.Submit();
        }
    }
}