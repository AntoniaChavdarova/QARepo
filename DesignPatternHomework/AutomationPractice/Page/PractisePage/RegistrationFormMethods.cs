using OpenQA.Selenium;
using AutomationPractice.RegistrationUserModel;
using AutomationPractice.Core;
using AutomationPractice.Extensions;

namespace AutomationPractice.Page
{
    public partial class RegistrationForm : BasePage
    {

        public RegistrationForm(WebDriver driver)
            : base(driver)
        {

        }

        public void FillForm (RegistrationUser user)
        {


            FirstName.SetText(user.FirstName);
            LastName.SetText(user.LastName);
            Password.SetText(user.Password);
            City.SetText(user.City);
            Address.SetText(user.Address);
            PostCode.SetText(user.PostCode);
            State.SetText(user.State);
            Phone.SetText(user.Phone);
            Submit.ScrollTo().ToBeVisible().Click();
            


        }

      



    }
}
