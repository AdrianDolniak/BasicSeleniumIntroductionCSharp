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
    public class Excercise16
    {
        [TestMethod]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dynamic_loading/1");

            // Lokalizacja elementu i click
            IWebElement start = driver.FindElement(By.XPath("//*[@id='start']/button"));
            start.Click();

            // Explicity wait na załadowanie napisu
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.XPath("//*[@id='loading' and @style='display: none;']")));

            // Asercja
            IWebElement finish = driver.FindElement(By.XPath("//*[@id='finish']/h4"));
            Assert.AreEqual("Hello World!", finish.Text);

            // Zamkniecie przegladarki 
            driver.Quit();
        }
    }
}