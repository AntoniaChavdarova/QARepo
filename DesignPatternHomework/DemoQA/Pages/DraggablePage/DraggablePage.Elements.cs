using DemoQA.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages
{
   public partial class DraggablePage
    {

       

        public WebElement AxisRestrictedTab => Driver.FindElement(By.Id("draggableExample-tab-axisRestriction"));
        public WebElement OnlyYBox => Driver.FindElement(By.Id("restrictedY"));
        public WebElement OnlyXBox => Driver.FindElement(By.Id("restrictedX"));
        public WebElement ContainerRestricted => Driver.FindElement(By.Id("draggableExample-tab-containerRestriction"));
        public WebElement Container => Driver.FindElement(By.Id("containmentWrapper"));
        public WebElement DragBox => Driver.FindElement(By.XPath("//div[@id='containmentWrapper']/div"));

       

    }
}
