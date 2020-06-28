using DemoQA.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages
{
   public partial class DroppablePage:DemoQAPage
    {
        public DroppablePage(WebDriver driver)
            :base(driver)
        {

        }

        public override string Url => "http://demoqa.com/droppable";
    }
}
