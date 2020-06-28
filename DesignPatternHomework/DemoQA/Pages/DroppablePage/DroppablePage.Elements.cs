using DemoQA.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages
{
   public partial class DroppablePage
    {

        public WebElement  DragMe => Driver.FindElement(By.Id("draggable"));
        public WebElement  DropHere => Driver.FindElement(By.Id("droppable"));
        
       public WebElement  AxisRestrictedTab => Driver.FindElement(By.Id("droppableExample-tab-accept"));
        

        public WebElement  Acceptable => Driver.FindElement(By.Id("acceptable"));

        public WebElement ClassAfterAction => Driver.FindElement(By.Id("droppable"));  

      

        

        
    }

}
