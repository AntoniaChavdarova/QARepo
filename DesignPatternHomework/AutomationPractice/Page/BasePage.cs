using AutomationPractice.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace AutomationPractice.Page
{
   public abstract class BasePage
    {
        public BasePage(WebDriver driver)
        {
            Driver = driver;
              Driver.WrappedDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
     

        }

        public WebDriver Driver { get; }

      

        public virtual string Url { get; }

        public void NavigateTo()
        {


            Driver.Navigate(Url);

        }



    }
}
