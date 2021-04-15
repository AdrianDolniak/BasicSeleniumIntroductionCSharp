// <copyright file="RegisterPage.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM
{
    using System;
    using System.Threading;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    /// <summary>
    /// RegisterPage class.
    /// </summary>
    public class RegisterPage
    {
        private IWebDriver driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterPage"/> class.
        /// </summary>
        /// <param name="driver">The first name to join.</param>
        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement FName => this.driver.FindElement(By.Id("firstName"));

        private IWebElement LName => this.driver.FindElement(By.Id("Text1"));

        private IWebElement UName => this.driver.FindElement(By.Id("username"));

        private IWebElement Pass => this.driver.FindElement(By.Id("password"));

        private IWebElement Submit => this.driver.FindElement(By.ClassName("form-actions"));

        /// <summary>
        /// Metoda CreateNewUser.
        /// </summary>
        /// <param name="fname">The first name.</param>
        /// <param name="lname">The last name.</param>
        /// <param name="uname">The username.</param>
        /// <param name="password">The password.</param>
        public void CreateNewUser(string fname, string lname, string uname, string password)
        {
            this.FName.SendKeys(fname);
            this.LName.SendKeys(lname);
            this.UName.SendKeys(uname);
            this.Pass.SendKeys(password);
            this.Submit.Submit();
        }
    }
}