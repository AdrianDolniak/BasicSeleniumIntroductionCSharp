using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace ProjectSeleniumPOM
{
    public class RegisterPage
    {
        private IWebDriver driver;
        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement fName => driver.FindElement(By.Id("firstName"));
        private IWebElement lName => driver.FindElement(By.Id("Text1"));
        private IWebElement uName => driver.FindElement(By.Id("username"));
        private IWebElement pass => driver.FindElement(By.Id("password"));
        private IWebElement submit => driver.FindElement(By.ClassName("form-actions"));
        public void CreateNewUser(string fname, string lname, string uname, string password)
        {
            fName.SendKeys(fname);
            lName.SendKeys(lname);
            uName.SendKeys(uname);
            pass.SendKeys(password);
            submit.Submit();
        }
    }
}