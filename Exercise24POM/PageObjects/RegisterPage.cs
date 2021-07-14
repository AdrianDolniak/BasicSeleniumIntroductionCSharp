// <copyright file="RegisterPage.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM24
{
    using System;
    using System.Threading;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    /// <summary>
    /// RegisterPage class.
    /// </summary>
    public class RegisterPage : PageBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterPage"/> class.
        /// Creating a constructor, using a constructor from the PageBase class.
        /// </summary>
        /// <param name="driver">Driver.</param>
        public RegisterPage(IWebDriver driver)
            : base(driver) { }

        private IWebElement FName => this.Driver.FindElement(By.Id("firstName"));

        private IWebElement LName => this.Driver.FindElement(By.Id("Text1"));

        private IWebElement UName => this.Driver.FindElement(By.Id("username"));

        private IWebElement Pass => this.Driver.FindElement(By.Id("password"));

        private IWebElement Submit => this.Driver.FindElement(By.ClassName("form-actions"));

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