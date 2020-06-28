using AutomationPractice.Core;
using OpenQA.Selenium;


namespace AutomationPractice.Page
{
  public partial  class CreateAccountPage
    {

      

        public WebElement EmailField => Driver.FindElement(By.CssSelector("#email_create"));
        public WebElement SubmitButton => Driver.FindElement(By.CssSelector("#SubmitCreate"));


    }
}
