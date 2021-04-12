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
    public class Excercise22
    {
        [TestMethod]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/iframe");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Send some text to iFrame textbox
            driver.SwitchTo().Frame(0);
            IWebElement textBox = driver.FindElement(By.XPath("//*[@id='tinymce']"));
            textBox.Clear();
            textBox.SendKeys("some text");
            Thread.Sleep(3000);

            // Zamkniecie przegladarki 
            driver.Quit();
        }
    }
}