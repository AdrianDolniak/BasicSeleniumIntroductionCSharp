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
    public class Excercise21
    {
        [TestMethod]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/windows");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Lokalizacja elementu i click
            IWebElement start = driver.FindElement(By.CssSelector("#content > div > a"));
            start.Click();

            // Click link and get title new Tab
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            IWebElement text = driver.FindElement(By.ClassName("example"));
            Console.WriteLine("New tab text:" + text.Text);

            // Back to previusly Tab and get title 
            driver.SwitchTo().Window(driver.WindowHandles.FirstOrDefault());
            String TitleHome = driver.Title;
            Console.WriteLine("Home tab title:" + TitleHome);

            // Zamkniecie przegladarki 
            driver.Quit();
        }
    }
}