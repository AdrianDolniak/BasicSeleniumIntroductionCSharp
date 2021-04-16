// <copyright file="LoginPage.cs" company="AD">
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
    public class LoginPage
    {
        private IWebDriver driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginPage"/> class.
        /// </summary>
        /// <param name="driver">The first name to join.</param>
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement EmailAdressLog => this.driver.FindElement(By.Id("email"));

        private IWebElement PassLog => this.driver.FindElement(By.Id("passwd"));

        private IWebElement SubmitLog => this.driver.FindElement(By.Id("SubmitLogin"));

        private IWebElement EmailAdressReg => this.driver.FindElement(By.Id("email_create"));

        private IWebElement SubmitReg => this.driver.FindElement(By.Id("SubmitCreate"));

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