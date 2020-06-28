using DemoQA.Pages;
using DemoQA.Pages.HomePage;
using DemoQA.Utilities.Extensions;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System.IO;

namespace DemoQA.Tests
{
    public class NavigationToPages : BaseTest
    {
        private HomePage _homePage;
        private DemoQAPage _demoQaPage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _homePage = new HomePage(Driver);
            _demoQaPage = new DemoQAPage(Driver);
            _homePage.NavigateTo();
        }

        [Test]
       [TestCase("Sortable")]
       [TestCase("Selectable")]
       [TestCase("Resizable")]
       [TestCase("Droppable")]
       [TestCase("Dragabble")]
        public void SuccessfullyPageLoaded_When_NavigateToSortable(string sectionName)
        {


            _homePage.CategoryButton("Interactions").Click();

            _demoQaPage.ScrollTo(_demoQaPage.SubMenu(sectionName));
            _demoQaPage.SubMenu(sectionName).Click();

            

            _demoQaPage.AssertPageTitle(sectionName);



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
