using DemoQA.Core;
using OpenQA.Selenium;

namespace DemoQA.Utilities.Extensions
{
    public static class DriverExtensions
    {
       public static string GetCssColor(this WebElement element)
        {
            return element.WrappedElement.GetCssValue("background-color");
        }

        public static string GetCssAtribute(this WebElement element)
        {
            if (element is null)
            {
                throw new System.ArgumentNullException(nameof(element));
            }

            return element.GetAttribute("class");
        }


    }
}
