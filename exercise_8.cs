using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProjectSelenium
{
    [TestClass]
    public class Excercise8
    {
        [TestMethod]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/status_codes");

            // Zebranie listy elementów (liczba elementów + pierwszy element + asercja) 
            IList<IWebElement> elements = driver.FindElements(By.XPath("//*[@id='content']/div/ul/li"));
            Console.WriteLine("Number of elements:" + elements.Count());
            Console.WriteLine("Text of first elements:" + elements[0].Text);
            Assert.AreEqual("200", elements[0].Text);

            // Zamkniecie przegladarki
            driver.Quit();
        }
    }
}