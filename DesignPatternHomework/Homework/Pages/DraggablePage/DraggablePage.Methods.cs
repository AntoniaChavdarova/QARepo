using DemoQA.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages
{
   public partial class DraggablePage :DemoQAPage
    {
        public DraggablePage(WebDriver driver)
            :base(driver)
        {
                
        }
       

        public void DragAndDropOnlyYDiagonally()
        {
           
        }

        public override string Url => "http://www.demoqa.com/dragabble";
    }
}
