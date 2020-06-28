using DemoQA.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages
{
    public abstract class BasePage
    {

        public BasePage(WebDriver driver)
        {
            Driver = driver;
            Driver.WrappedDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        public WebDriver Driver { get; }
        protected Actions Builder { get; set; }

        public WebElement ScrollTo(WebElement element)
        {
            ((IJavaScriptExecutor)element.WrappedDriver).ExecuteScript("arguments[0].scrollIntoView(true);", element.WrappedElement);
            return element;
        }

        public virtual string Url { get; }

        public void NavigateTo() {


            Driver.Navigate(Url);

        }

      

    }

    }
