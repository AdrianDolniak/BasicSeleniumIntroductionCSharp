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
    public class Excercise14
    {
        [TestMethod]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-select-dropdown-demo.html");

            // Lokalizacja elementu dropdown i wybranie
            IWebElement element = driver.FindElement(By.Id("select-demo"));
            SelectElement select = new SelectElement(element);
            select.SelectByText("Sunday");

            //Asercja
            IWebElement text = driver.FindElement(By.XPath("//*[@id='easycont']/div/div[2]/div[1]/div[2]/p[2]"));
            Assert.AreEqual("Day selected :- Sunday", text.Text);

            // Lokalizacja elementu multi i wybranie
            IWebElement elements = driver.FindElement(By.Id("multi-select"));
            SelectElement selects = new SelectElement(elements);
            selects.SelectByValue("California");

            IWebElement printMe = driver.FindElement(By.XPath("//*[@id='printMe']"));
            printMe.Click();

            //Asercja
            IWebElement multi = driver.FindElement(By.XPath(" //*[@id='easycont']/div/div[2]/div[2]/div[2]/p[2]"));
            Assert.AreEqual("First selected option is : California", multi.Text);
            Thread.Sleep(5000);

            // Zamkniecie przegladarki 
            driver.Quit();
        }
    }
}