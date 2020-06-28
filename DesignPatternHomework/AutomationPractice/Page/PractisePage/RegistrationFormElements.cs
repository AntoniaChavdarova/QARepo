using AutomationPractice.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;



namespace AutomationPractice.Page
{
    public partial class RegistrationForm : BasePage
    {


        public WebElement PageTitle => Driver.FindElement(By.XPath("//*[normalize-space(text())='Create an account']"));
        public WebElement FirstName => Driver.FindElement(By.CssSelector("#customer_firstname"));
        public WebElement LastName => Driver.FindElement(By.CssSelector("#customer_lastname"));
        public WebElement EmailField => Driver.FindElement(By.CssSelector("#email"));
        public WebElement Password => Driver.FindElement(By.CssSelector("#passwd"));

        public WebElement Address => Driver.FindElement(By.CssSelector("#address1"));
        public WebElement City => Driver.FindElement(By.Id("city"));
        public WebElement State => Driver.FindElement(By.CssSelector("#id_state"));
        public WebElement PostCode => Driver.FindElement(By.CssSelector("#postcode"));
        public WebElement Phone => Driver.FindElement(By.CssSelector("#phone_mobile"));
        public WebElement Submit => Driver.FindElement(By.CssSelector("#submitAccount"));
        public WebElement ActualMessage => Driver.FindElement(By.CssSelector(".alert.alert-danger"));









    }
}




