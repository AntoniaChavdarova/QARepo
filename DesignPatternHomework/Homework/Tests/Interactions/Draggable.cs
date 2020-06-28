using DemoQA.Pages;
using DemoQA.Tests;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System.IO;

namespace DemoQA.Interactions
{
    [TestFixture]
    public class Draggable : BaseTest
    {
        private DraggablePage _draggablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();

            _draggablePage = new DraggablePage(Driver);
            _draggablePage.NavigateTo();
        }

        [Test]
        public void ElementYIsSame_When_DragAndDropOnlyXDiagonally()
        {
            _draggablePage.AxisRestrictedTab.Click();


            var yBefore = _draggablePage.OnlyXBox.Location.Y;
            Builder.DragAndDropToOffset(_draggablePage.OnlyXBox.WrappedElement, 100, 100).Perform();
            var yAfter = _draggablePage.OnlyXBox.Location.Y;

            Assert.AreEqual(yBefore, yAfter);
        }

        [Test]
        public void ElementXIsSame_When_DragAndDropOnlyYDiagonally()
        {
            _draggablePage.AxisRestrictedTab.Click();

            var xBefore = _draggablePage.OnlyYBox.Location.X;

            Builder.DragAndDropToOffset(_draggablePage.OnlyYBox.WrappedElement, 100, 100).Perform();
            var xAfter = _draggablePage.OnlyYBox.Location.X;

            Assert.AreEqual(xBefore, xAfter);

        }

        [Test]
        public void ElementStillInBox_When_DragAndDropOutOfBox()
        {
            _draggablePage.ContainerRestricted.Click();

            Builder.DragAndDropToOffset(_draggablePage.DragBox.WrappedElement, 0, _draggablePage.Container.Size.Height - 100).Perform();

            Assert.IsNotNull(_draggablePage.Container.FindElement(By.TagName("div")));
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
