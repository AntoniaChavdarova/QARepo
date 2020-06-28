using DemoQA.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages
{
   public partial class ResizeablePage
    {

     
        public WebElement Container => Driver.FindElement(By.ClassName("constraint-area"));
        public WebElement ResizeableBox => Driver.FindElement(By.Id("resizableBoxWithRestriction"));
        public WebElement ResizeArrow => Driver.FindElement(By.XPath("//span[contains(@class, 'react-resizable-handle')]"));
    }
}
