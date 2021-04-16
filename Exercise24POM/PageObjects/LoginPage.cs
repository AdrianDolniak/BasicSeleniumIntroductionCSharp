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

        private IWebElement UNameLog => this.driver.FindElement(By.Id("username"));

        private IWebElement PassLog => this.driver.FindElement(By.Id("password"));

        private IWebElement SubmitLog => this.driver.FindElement(By.ClassName("form-actions"));

        private IWebElement Register => this.driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/form/div[3]/a"));

        private IWebElement Loguot => this.driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/p[3]/a"));

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
    }
}