﻿// <copyright file="LoginPage.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM25
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
        /// Creating a constructor, using a constructor from the PageBase class.
        /// </summary>
        /// <param name="driver">Driver.</param>
        public LoginPage(IWebDriver driver)
    : base(driver) { }

        private IWebElement EmailAdressLog => this.Driver.FindElement(By.Id("email"));

        private IWebElement PassLog => this.Driver.FindElement(By.Id("passwd"));

        private IWebElement SubmitLog => this.Driver.FindElement(By.Id("SubmitLogin"));

        private IWebElement EmailAdressReg => this.Driver.FindElement(By.Id("email_create"));

        private IWebElement SubmitReg => this.Driver.FindElement(By.Id("SubmitCreate"));

        /// <summary>
        /// Metoda Login.
        /// </summary>
        /// <param name="emailaddressnamelog">The username.</param>
        /// <param name="passlog">The password.</param>
        public void Login(string emailaddressnamelog, string passlog)
        {
            this.EmailAdressLog.SendKeys(emailaddressnamelog);
            this.PassLog.SendKeys(passlog);
            this.SubmitLog.Click();
        }

        /// <summary>
        /// Metoda GoToRegisterPage.
        /// </summary>
        /// <param name="emailaddressreg">The username.</param>
        public void GoToRegisterPage(string emailaddressreg)
        {
            this.EmailAdressReg.SendKeys(emailaddressreg);
            this.SubmitReg.Click();
        }
    }
}