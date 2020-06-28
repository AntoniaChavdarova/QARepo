using DemoQA.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.HomePage
{
   public partial class HomePage :BasePage
    {

        public WebElement CategoryButton(string categoryName) =>
            Driver.FindElement(By.XPath($"//*[normalize-space(text())='{categoryName}']/ancestor::div[contains(@class, 'top-card')]"));
    }
}
