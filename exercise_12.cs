using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Interactions;

namespace UnitTestProjectSelenium
{
    [TestClass]
    public class Excercise12
    {
        [TestMethod]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/status_codes");

            // Lokalizacja elementu 200
            IWebElement element = driver.FindElement(By.XPath("//*[@id='content']/div/ul/li[1]/a"));
            element.Click();

            //Pobranie tekstu ze strony
            IWebElement text = driver.FindElement(By.CssSelector("#content > div > h3"));
            Console.WriteLine(text.Text);

            //Assercja
            Assert.AreEqual("Status Codes", text.Text);

            // Zamkniecie przegladarki 
            driver.Quit();
        }
    }
}