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
    public class Excercise23
    {
        [TestMethod]
        public void SampleTestChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigacja do strony
            driver.Navigate().GoToUrl("https://demos.telerik.com/kendo-ui/dragdrop/index");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Actions class method to drag and drop 
            Actions actions = new Actions(driver);
            IWebElement from = driver.FindElement(By.Id("draggable"));
            IWebElement to = driver.FindElement(By.Id("droptarget"));

            //Perform drag and drop
            actions.DragAndDrop(from, to).Perform();

            //verify text changed in to 'You did great!' box 
            String textTo = to.Text;
            if (textTo.Equals("You did great!"))
            {
                Console.WriteLine("PASS: Source is dropped to target as expected");
            }
            else
            {
                Console.WriteLine("FAIL: Source couldn't be dropped to target as expected");
            }
            Assert.AreEqual(textTo, "You did great!");
            Thread.Sleep(3000);
 
            // Zamkniecie przegladarki 
            driver.Quit();
        }
    }
}