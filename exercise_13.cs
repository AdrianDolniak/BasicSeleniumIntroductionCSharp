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
    public class Excercise13
    {
        [TestMethod]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dropdown");

            // Lokalizacja elementu dropdown i wybranie opcji 2
            IWebElement element = driver.FindElement(By.Id("dropdown"));
            SelectElement select = new SelectElement(element);
            select.SelectByText("Option 2");
            Thread.Sleep(5000);

            // Zamkniecie przegladarki 
            driver.Quit();
        }
    }
}