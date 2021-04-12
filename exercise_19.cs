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
    public class Excercise19
    {
        [TestMethod]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Get page title using JavaScriptExecutor
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            String TitleName = js.ExecuteScript("return document.title;").ToString();
            Console.WriteLine("Title of the page = " + TitleName);

            // Zamkniecie przegladarki 
            driver.Quit();
        }
    }
}