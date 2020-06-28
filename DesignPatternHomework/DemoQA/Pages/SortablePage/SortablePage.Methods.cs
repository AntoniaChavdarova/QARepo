using DemoQA.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages
{
  public partial class SortablePage :DemoQAPage
    {
        public SortablePage(WebDriver driver)
            :base (driver)
        {

        }

        public override string Url => "http://demoqa.com/sortable";
    }
}
