using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProjectSelenium
{
    [TestClass]
    public class Excercise6
    {
        [TestMethod]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/");

            // Lokalizacja pola "Start Practising” 
            IWebElement startPractisingID = driver.FindElement(By.Id("btn_basic_example"));
            IWebElement startPractisingCSS = driver.FindElement(By.CssSelector("#btn_basic_example"));
            IWebElement startPractisingXPath = driver.FindElement(By.XPath("//*[@id='btn_basic_example']"));

            // Zamkniecie przegladarki
            driver.Quit();
        }
    }
}