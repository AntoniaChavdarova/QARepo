
using AutoFixture;
using AutomationPractice.Core;
using OpenQA.Selenium;
using AutomationPractice.Factories;

namespace AutomationPractice.Page
{
   public partial class CreateAccountPage :BasePage
    {
        public string SignInEmail;
        public CreateAccountPage(WebDriver driver)
            :base(driver)
        {

        }

     

        private string GetRandomEmail()
        {
            var fixture = new Fixture();
            var mail = fixture.Create<string>();
            return $"{mail}@gmail.com";
        }

        public void SignIn()
        {
           SignInEmail = GetRandomEmail();
            this.EmailField.SetText(SignInEmail);
            this.SubmitButton.Click();
        }

       
     

        public override string Url => "http://automationpractice.com/index.php?controller=authentication&back=my-account#account-creation";
    }
}
