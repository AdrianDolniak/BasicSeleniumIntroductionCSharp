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
    public class Excercise17
    {
        [TestMethod]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("http://www.globalsqa.com/angularJs-protractor/registration-login-example/#/login");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Rejestracja
            IWebElement register = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/form/div[3]/a"));
            register.Click();
            IWebElement fName = driver.FindElement(By.Id("firstName"));
            fName.SendKeys("Adrian");
            IWebElement lName = driver.FindElement(By.Id("Text1"));
            lName.SendKeys("Dolniak");
            IWebElement uName = driver.FindElement(By.Id("username"));
            uName.SendKeys("adriandolniak");
            IWebElement pass = driver.FindElement(By.Id("password"));
            pass.SendKeys("1234");
            IWebElement submit = driver.FindElement(By.ClassName("form-actions"));
            submit.Submit();
            Thread.Sleep(5000);

            // Logowanie
            IWebElement uNameLog = driver.FindElement(By.Id("username"));
            uNameLog.SendKeys("adriandolniak");
            IWebElement passLog = driver.FindElement(By.Id("password"));
            passLog.SendKeys("1234");
            IWebElement submitLog = driver.FindElement(By.ClassName("form-actions"));
            submitLog.Submit();
            Thread.Sleep(5000);

            // Asercja
            IWebElement isUser = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/ul/li"));
            Assert.AreEqual("adriandolniak (Adrian Dolniak) - Delete", isUser.Text);

            // Wylogowanie
            IWebElement loguot = driver.FindElement(By.CssSelector("body > div.jumbotron > div > div > div > p:nth-child(6) > a"));
            loguot.Click();

            // Zamkniecie przegladarki 
            driver.Quit();
        }
    }
}