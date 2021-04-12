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
    public class Excercise9
    {
        [TestMethod]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/checkboxes");

            // Lokalizacja checkboxa 
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='checkboxes']/input[1]"));

            // Kliknięcie checkboxa
            Thread.Sleep(5000);
            loginButton.Click();
            Thread.Sleep(5000);
            loginButton.Submit();
            Thread.Sleep(5000);

            // Podwójne kliknięcie checkboxa
            Actions action = new Actions(driver);
            IWebElement element = driver.FindElement(By.XPath("//*[@id='checkboxes']/input[1]"));
            action.DoubleClick(element).Perform();


            // Zamkniecie przegladarki
            driver.Quit();
        }
    }
}