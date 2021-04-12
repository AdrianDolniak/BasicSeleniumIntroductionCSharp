using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProjectSelenium
{
    [TestClass]
    public class Excercise7
    {
        [TestMethod]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("https://www.linkedin.com/");

            // Lokalizacja pola "Salaries” 
            IWebElement startPractisingCSS = driver.FindElement(By.CssSelector("#main-content > section:nth-child(8) > div > div > div:nth-child(2) > ul > li:nth-child(3) > a"));

            // Zamkniecie przegladarki
            driver.Quit();
        }
    }
}