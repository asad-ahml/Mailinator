using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mailinator.Classes
{
    class Pricing
    {
        IWebDriver driver = null;

        public void Browser()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.mailinator.com/");

        }
        public void PersonalPlan()
        {
            // Test Case #6 Make sure link to Login present on page
            driver.FindElement(By.XPath("//*[@class='title' and h2='Personal']"));
        }

        public void ValidateStartYourFreeTrial()
        {
            // Test Case #7 Make sure link to Login present on page
            driver.FindElement(By.XPath("//*[@class='btn btn-primary btn-block']"));
        }
        

    }
}
