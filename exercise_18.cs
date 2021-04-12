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
    public class Excercise18
    {
        [TestMethod]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/javascript_alerts");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Click one of buttons, handle an event and check result in textbox
            IWebElement alert = driver.FindElement(By.CssSelector("#content > div > ul > li:nth-child(1) > button"));
            alert.Click();
            driver.SwitchTo().Alert().Accept();

            IWebElement result = driver.FindElement(By.CssSelector("#result"));
            Assert.AreEqual("You successfully clicked an alert", result.Text);

            // Zamkniecie przegladarki 
            driver.Quit();
        }
    }
}