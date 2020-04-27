using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mailinator
{
    class Email
    {
        OpenQA.Selenium.IWebDriver driver = null;

        public void Browser()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.mailinator.com/");

        }

        public void ValidateInbox()
        {
            // Test Case #4 Make sure Inbox field present on page
            driver.FindElement(By.XPath("//*[@id='inbox_field']"));
            
        }

        public void ValidateCookieBar()
        {
            // Test Case #5 Make sure link to Cookie Bar present on page
            driver.FindElement(By.XPath("//*[@id='cookieconsent:desc']"));
        }
    }
}
