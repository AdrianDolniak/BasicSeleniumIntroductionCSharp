// <copyright file="PageBase.cs" company="AD">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSeleniumPOM25
{
    using OpenQA.Selenium;

    /// <summary>
    /// PageBase class.
    /// </summary>
    public class PageBase
    {
        /// <summary> Password used for logging.</summary>
        public string Password = "12345";

        /// <summary> UserEMail used for logging.</summary>
        public string UserEMail = "aaa@ob.pl";

        /// <summary>
        /// Initializes a new instance of the <see cref="PageBase"/> class.
        /// </summary>
        /// <param name="driver">Driver.</param>
        /// <returns>Return driver.</returns>
        public PageBase(IWebDriver driver)
        {
            this.Driver = driver;
        }

        /// <summary> Gets or sets driver definition.</summary>
        protected IWebDriver Driver { get; set; }
    }
}
