

using DemoQA.Core;
using OpenQA.Selenium;

namespace DemoQA.Pages.HomePage
{
   public partial class HomePage
    {
        public HomePage(WebDriver driver)
            : base(driver)
        {

        }

        public override string Url => "http://demoqa.com";

    }
}
