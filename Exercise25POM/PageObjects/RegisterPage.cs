// <copyright file="RegisterPage.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM25
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
            : base(driver)
        {
        }

        private IWebElement Title => this.Driver.FindElement(By.Id("uniform-id_gender1"));

        private IWebElement FName => this.Driver.FindElement(By.Id("customer_firstname"));

        private IWebElement LName => this.Driver.FindElement(By.Id("customer_lastname"));

        private IWebElement Pass => this.Driver.FindElement(By.Id("passwd"));

        private IWebElement DateofBirthDay => this.Driver.FindElement(By.Id("days"));

        private IWebElement DateofBirthMonths => this.Driver.FindElement(By.Id("months"));

        private IWebElement DateofBirthTears => this.Driver.FindElement(By.Id("years"));

        private IWebElement Address => this.Driver.FindElement(By.Id("address1"));

        private IWebElement City => this.Driver.FindElement(By.Id("city"));

        private IWebElement State => this.Driver.FindElement(By.Id("id_state"));

        private IWebElement PostalCode => this.Driver.FindElement(By.Id("postcode"));

        private IWebElement Country => this.Driver.FindElement(By.Id("id_country"));

        private IWebElement MobilePhone => this.Driver.FindElement(By.Id("phone_mobile"));

        private IWebElement SubmitCreate => this.Driver.FindElement(By.Id("submitAccount"));

        private IWebElement IsUser => this.Driver.FindElement(By.ClassName("account"));

        /// <summary>
        /// Metoda CreateNewUser.
        /// </summary>
        /// <param name="fname">The first name.</param>
        /// <param name="lname">The last name.</param>
        /// <param name="password">The password.</param>
        /// <param name="day">The day of birth.</param>
        /// <param name="month">The month of birth.</param>
        /// <param name="year">The year of birth.</param>
        /// <param name="address"> Yhe Adress.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="postalcode">The postalcode.</param>
        /// <param name="country">The country.</param>
        /// <param name="mobilephone">The mobile phone number.</param>
        public void CreateNewUser(string fname, string lname, string password, string day, string month, string year, string address, string city, string state, string postalcode, string country, string mobilephone)
        {
            this.Title.Click();
            this.FName.SendKeys(fname);
            this.LName.SendKeys(lname);
            this.Pass.SendKeys(password);
            this.DateofBirthDay.SendKeys(day);
            this.DateofBirthMonths.SendKeys(month);
            this.DateofBirthTears.SendKeys(year);
            this.Address.SendKeys(address);
            this.City.SendKeys(city);
            this.State.SendKeys(state);
            this.PostalCode.SendKeys(postalcode);
            this.Country.SendKeys(country);
            this.MobilePhone.SendKeys(mobilephone);
            this.SubmitCreate.Click();
        }

        /// <summary>
        /// Metoda RegistrationSuccessful.
        /// </summary>
        /// <returns>Returns text.</returns>
        public string RegistrationSuccessful()
        {
            var isUser = this.IsUser.Text;
            return isUser;
        }
    }
}