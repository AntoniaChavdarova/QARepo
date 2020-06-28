

using AutomationPractice.Page;
using AutomationPractice.RegistrationUserModel;
using AutomationPractice.Test;
using NUnit.Framework;
using AutomationPractice.Factories;
using NUnit.Framework.Interfaces;
using System.IO;
using OpenQA.Selenium;

namespace AutomationPractice.Tests.PractiseTestForm
{
    public class RegistrationFormTests :BaseTest

    {
      
        private RegistrationForm _registrationForm;
        private RegistrationUser _user;
      
        private CreateAccountPage _createAccountPage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _createAccountPage = new CreateAccountPage(Driver);
            _createAccountPage.NavigateTo();
        

            _registrationForm = new RegistrationForm(Driver);
          
            _user = UserFactory.CreateValidUser();
            _createAccountPage.SignIn();




        }
      



        [Test]
        public void MessageDisplayed_When_FirstNameIsRequired()
        {


            _user.SkipFirstName();

            _registrationForm.FillForm(_user);

            _registrationForm.MessageWithMissingValue(_user.ErrorMessage);



        }

        [Test]
        public void MessageDisplayed_When_LastName_Is_Required()
        {


            _user.SkipLastName();
            _registrationForm.FillForm(_user);

            _registrationForm.MessageWithMissingValue(_user.ErrorMessage);

            }

        [Test]
        public void MessageDisplayed_When_Password_Is_Required()
        {


            _user.SkipPassword();

            _registrationForm.FillForm(_user);

            _registrationForm.MessageWithMissingValue(_user.ErrorMessage);

        }

        [Test]
        public void MessageDisplayed_When_City_Is_Required()
        {


            _user.SkipCity();

            _registrationForm.FillForm(_user);

            _registrationForm.MessageWithMissingValue(_user.ErrorMessage);

        }

        [Test]
        public void MessageDisplayed_When_Address_Is_Required()
        {


            _user.SkipAddress();

            _registrationForm.FillForm(_user);

            _registrationForm.MessageWithMissingValue(_user.ErrorMessage);

        }
      

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string dirPath = Path.GetFullPath(@"..\..\..\", Directory.GetCurrentDirectory());
                var screenshot = ((ITakesScreenshot)Driver.WrappedDriver).GetScreenshot();
                screenshot.SaveAsFile($"{dirPath}\\Screenshots\\{TestContext.CurrentContext.Test.FullName}.png", ScreenshotImageFormat.Png);
            }

            Driver.Quit();
        }
    }
}
