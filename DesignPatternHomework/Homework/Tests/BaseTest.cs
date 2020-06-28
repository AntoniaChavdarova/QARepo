using DemoQA.Core;
using NUnit.Framework;
using OpenQA.Selenium;

using OpenQA.Selenium.Interactions;


namespace DemoQA.Tests
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
