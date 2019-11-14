using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestAutomationProject1
{
    [TestClass]
    public class SampleTest
    {
        [TestMethod]
        public void FindHeader()
        {
            IWebDriver driver;
            driver = new ChromeDriver();
            //driver.Url = "https://www.google.com";
            driver.Navigate().GoToUrl("https://pbwebapplication1appservice.azurewebsites.net/");
            string str1 = driver.FindElement(By.TagName("h1")).Text.ToString();
            if (str1.Contains("HELLO California peeps")) { }
            else
                throw NoSuchElementException();
        }

        private Exception NoSuchElementException()
        {
            throw new NotImplementedException();
        }
    }
}
