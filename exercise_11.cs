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
    public class Excercise11
    {
        [TestMethod]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-first-form-demo.html");
            Thread.Sleep(5000);
            driver.FindElement(By.Id("at-cv-lightbox-close")).Click();

            // Lokalizacja pola A i B
            IWebElement a = driver.FindElement(By.XPath("//*[@id='sum1']"));
            IWebElement b = driver.FindElement(By.XPath("//*[@id='sum2']"));

            // Wpisz A
            Thread.Sleep(5000);
            a.SendKeys("2");

            // Wpisz B
            Thread.Sleep(5000);
            b.SendKeys("2");

            IWebElement getTotal = driver.FindElement(By.XPath("//*[@id='gettotal']/button"));
            getTotal.Click();

            IWebElement displayValue = driver.FindElement(By.XPath("//*[@id='displayvalue']"));
            Assert.AreEqual("4", displayValue.Text);

            // Zamkniecie przegladarki 
            driver.Quit();
        }
    }
}