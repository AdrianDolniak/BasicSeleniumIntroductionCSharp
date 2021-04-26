// <copyright file="RegisterPage.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM25Inheritance
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
        private static IWebElement Title => Driver.FindElement(By.Id("uniform-id_gender1"));

        private static IWebElement FName => Driver.FindElement(By.Id("customer_firstname"));

        private static IWebElement LName => Driver.FindElement(By.Id("customer_lastname"));

        private static IWebElement Pass => Driver.FindElement(By.Id("passwd"));

        private static IWebElement DateofBirthDay => Driver.FindElement(By.Id("days"));

        private static IWebElement DateofBirthMonths => Driver.FindElement(By.Id("months"));

        private static IWebElement DateofBirthTears => Driver.FindElement(By.Id("years"));

        private static IWebElement Address => Driver.FindElement(By.Id("address1"));

        private static IWebElement City => Driver.FindElement(By.Id("city"));

        private static IWebElement State => Driver.FindElement(By.Id("id_state"));

        private static IWebElement PostalCode => Driver.FindElement(By.Id("postcode"));

        private static IWebElement Country => Driver.FindElement(By.Id("id_country"));

        private static IWebElement MobilePhone => Driver.FindElement(By.Id("phone_mobile"));

        private static IWebElement SubmitCreate => Driver.FindElement(By.Id("submitAccount"));

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
        public static void CreateNewUser(string fname, string lname, string password, string day, string month, string year, string address, string city, string state, string postalcode, string country, string mobilephone)
        {
            Title.Click();
            FName.SendKeys(fname);
            LName.SendKeys(lname);
            Pass.SendKeys(password);
            DateofBirthDay.SendKeys(day);
            DateofBirthMonths.SendKeys(month);
            DateofBirthTears.SendKeys(year);
            Address.SendKeys(address);
            City.SendKeys(city);
            State.SendKeys(state);
            PostalCode.SendKeys(postalcode);
            Country.SendKeys(country);
            MobilePhone.SendKeys(mobilephone);
            SubmitCreate.Click();
        }
    }
}