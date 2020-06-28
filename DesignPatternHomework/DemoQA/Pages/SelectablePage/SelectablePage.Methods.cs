using DemoQA.Core;
using OpenQA.Selenium;


namespace DemoQA.Pages
{
    public partial class SelectablePage:DemoQAPage
    {
        public SelectablePage(WebDriver driver)
            :base(driver)
        {

        }


        public override string Url => "http://www.demoqa.com/selectable";
    }
}
