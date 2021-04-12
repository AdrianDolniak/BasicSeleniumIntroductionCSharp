using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProjectSelenium
{
    [TestClass]
    public class Excercise5
    {
        [TestMethod]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/login");

            // Lokalizacja pola loginu
            IWebElement inputLogin = driver.FindElement(By.Id("username"));

            // Wpisanie loginu
            inputLogin.SendKeys("tomsmith");

            // Lokalizacja pola hasła
            IWebElement inputPassword = driver.FindElement(By.Name("password"));

            // Wpisanie hasła
            inputPassword.SendKeys("SuperSecretPassword!");

            // Lokalizacja przycisku logowania 
            IWebElement loginButton = driver.FindElement(By.XPath("//button[@type='submit']"));

            // Kliknięcie przycisku logowania
            loginButton.Click();

            // Zaczekanie na zalogowanie użytkownika
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement result = wait.Until(drv => drv.FindElement(By.CssSelector("h2")));

            // Assercja sprawdzajaca tytuł strony
            Assert.AreEqual(result.Text, "Secure Area");

            // Zamkniecie przegladarki
            driver.Quit();
        }
    }
}