using DemoQA.Pages;
using DemoQA.Tests;
using DemoQA.Utilities.Extensions;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System.IO;

namespace DemoQA.Interactions
{
    [TestFixture]
    public class Resizable : BaseTest
    {
        private ResizeablePage _resizeablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _resizeablePage = new ResizeablePage(Driver) ;
            _resizeablePage.NavigateTo();
        }

        [Test]
        public void ElementSizeIsMaximum_When_ResizeMoreThanMaximum()
        {
           

            Builder.DragAndDropToOffset(_resizeablePage.ResizeArrow.WrappedElement, 300, 100).Perform();

            Assert.AreEqual(_resizeablePage.Container.Size.Height, _resizeablePage.ResizeableBox.Size.Height);
            Assert.AreEqual(_resizeablePage.Container.Size.Width, _resizeablePage.ResizeableBox.Size.Width);
        }

        [Test]
        public void ElementSizeIsMinimum_When_ResizeToMinimum()
        {
            

            Builder.DragAndDropToOffset(_resizeablePage.ResizeArrow.WrappedElement, -50, -50).Perform();

            Assert.AreEqual(150, _resizeablePage.ResizeableBox.Size.Height);
            Assert.AreEqual(150, _resizeablePage.ResizeableBox.Size.Width);
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
