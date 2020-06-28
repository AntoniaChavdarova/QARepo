
using DemoQA.Pages;
using DemoQA.Tests;

using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq;

using DemoQA.Utilities.Extensions;
using NUnit.Framework.Interfaces;
using System.IO;
using System;

namespace DemoQA.Interactions
{
    [TestFixture]
    public class Selectable : BaseTest
    {
        private SelectablePage _selectablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _selectablePage = new SelectablePage(Driver);
            _selectablePage.NavigateTo();
        }

        [Test]
      
        public void SelectItemColorChange_When_SelectItem([Range(0, 3)] int index)
        {
           

            _selectablePage.ListOFOptions[index].Click();

            Assert.AreEqual("rgba(0, 123, 255, 1)", _selectablePage.ListOFOptions[index].GetCssColor());
        }

        [Test]
        public void AllItemsColorChanged_When_MoreThanIOneItem()
        {
            

            foreach (var option in _selectablePage.ListOFOptions)
            {
                option.Click();
            }

            Assert.IsTrue(_selectablePage.ListOFOptions.All(o => o.GetCssColor() == "rgba(0, 123, 255, 1)"));
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
