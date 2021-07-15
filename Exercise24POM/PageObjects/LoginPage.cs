// <copyright file="LoginPage.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM24
{
    using System;
    using System.Threading;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    /// <summary>
    /// LoginPage class.
    /// </summary>
    public class LoginPage : PageBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginPage"/> class.
        /// </summary>
        /// <param name="driver">Driver.</param>
        public LoginPage(IWebDriver driver)
            : base(driver)
        {
        }

        private IWebElement UNameLog => this.Driver.FindElement(By.Id("username"));

        private IWebElement PassLog => this.Driver.FindElement(By.Id("password"));

        private IWebElement SubmitLog => this.Driver.FindElement(By.ClassName("form-actions"));

        private IWebElement Register => this.Driver.FindElement(By.CssSelector("a[href='#/register']"));

        private IWebElement Loguot => this.Driver.FindElement(By.CssSelector("a[href='#/login']"));

        private IWebElement IsUserNotLogged => this.Driver.FindElement(By.CssSelector("[class='ng-binding ng-scope alert alert-danger']"));

        /// <summary>
        /// Metoda Login.
        /// </summary>
        /// <param name="unamelog">The username.</param>
        /// <param name="passlog">The password.</param>
        public void Login(string unamelog, string passlog)
        {
            this.UNameLog.SendKeys(unamelog);
            this.PassLog.SendKeys(passlog);
            this.SubmitLog.Submit();
        }

        /// <summary>
        /// Metoda LogOut.
        /// </summary>
        public void LogOut()
        {
            this.Loguot.Click();
        }

        /// <summary>
        /// Metoda GoToRegisterPage.
        /// </summary>
        public void GoToRegisterPage()
        {
            this.Register.Click();
        }

        /// <summary>
        /// Metoda UserNotLogged.
        /// </summary>
        /// <returns>Returns text.</returns>
        public string UserNotLogged()
        {
            var isUserNotLogged = this.IsUserNotLogged.Text;
            return isUserNotLogged;
        }
    }
}