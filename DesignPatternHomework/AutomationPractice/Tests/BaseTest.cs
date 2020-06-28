using AutomationPractice.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace AutomationPractice.Test
{
 
    
        [TestFixture]
        public class BaseTest
        {
            protected WebDriver Driver { get; set; }

            protected Actions Builder { get; set; }



        
        public void Initialize()
        {

            Driver = new WebDriver();
            Driver.Start(Browser.Chrome);
            Builder = new Actions(Driver.WrappedDriver);
        }

       
        }
}
 