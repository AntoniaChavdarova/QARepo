using AutoFixture;
using AutomationPractice.Page;
using AutomationPractice.Test;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System.IO;

namespace AutomationPractice.Tests
{
   public class Navigation :BaseTest
    {
        private CreateAccountPage _createAccountPage;
  
        private RegistrationForm _registrationForm;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _createAccountPage = new CreateAccountPage(Driver);
            _createAccountPage.NavigateTo();
       
            _registrationForm = new RegistrationForm(Driver);


        }

        [Test]
        public void NavigateToLoginPage()
        {

            _createAccountPage.SignIn();

            _registrationForm.AssertPageTitle("create an account");
           
           




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

