using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mailinator
{
    class Home
    {
        IWebDriver driver = null;

        public void Browser()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.mailinator.com/");

        }
        public void HomeLink()
        {
            // Test Case #1  Make sure link to Home present on page
            driver.FindElement(By.XPath("//*[@class ='nav-item' and text() = 'Home']"));
        }
        public void EmailLink()
        {
            // Test Case #2  Make sure link to Email present on page
            driver.FindElement(By.XPath("//*[@class ='nav-item' and text() = 'Email']"));
        }

        public void LoginLink()
        {
            // Test Case #3  Make sure link to Login present on page
            driver.FindElement(By.XPath("//*[@class='modal-login d-flex justify-content-center align-items-center w-100' and text () = 'Login']"));
        }
        


    }
}
