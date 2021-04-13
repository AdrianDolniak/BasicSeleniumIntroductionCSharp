using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace ProjectSeleniumPOM
{ 
    public class TestBase
    {
        private IWebDriver driver;
        public TestBase(IWebDriver driver)
        {
            this.driver = driver;
        }
        [SetUp]
        public void Start()
            {
                driver = new ChromeDriver("D:\\Testing\\Visual Studio C # Testing\\");
                driver.Url = "https://www.globalsqa.com/angularJs-protractor/registration-login-example/#/login";
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }
        [TearDown]
        public void Stop()
            {
                driver.Quit();
            }
        
    }
}