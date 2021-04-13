using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace ProjectSeleniumPOM
{
    public class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement uNameLog => driver.FindElement(By.Id("username"));
        private IWebElement passLog => driver.FindElement(By.Id("password"));
        private IWebElement submitLog => driver.FindElement(By.ClassName("form-actions"));
        private IWebElement register => driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/form/div[3]/a"));
        private IWebElement loguot => driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/p[3]/a"));
        public void Login(string unamelog, string passlog)
        {
            uNameLog.SendKeys(unamelog);
            passLog.SendKeys(passlog);
            submitLog.Submit();
        }
        public void LogOut()
        {
            loguot.Click();
        }
        public void GoToRegisterPage()
        {
            register.Click();
        }
    }
}