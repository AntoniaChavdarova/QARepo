using DemoQA.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages
{
   public partial class ResizeablePage:DemoQAPage
    {
        public ResizeablePage(WebDriver driver)
            :base(driver)
        {

        }

        public override string Url => "http://www.demoqa.com/resizable";
    }
}
