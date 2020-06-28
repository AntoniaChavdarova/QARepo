

using DemoQA.Core;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace DemoQA.Pages
{
    public partial class SelectablePage
    {

        public WebElement List => Driver.FindElement(By.Id("verticalListContainer"));
      
        public List<WebElement> ListOFOptions => List.FindElements(By.TagName("li")).ToList();

        
          
    }
}
