using DemoQA.Pages;
using DemoQA.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using DemoQA.Utilities.Extensions;
using NUnit.Framework.Interfaces;
using System.IO;

namespace DemoQA.Interactions
{
    [TestFixture]
    public class Droppable : BaseTest
    {
        private DroppablePage _droppablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _droppablePage = new DroppablePage(Driver);
            _droppablePage.NavigateTo();
        }

        [Test]
        public void DropElementChangeColorOfTarget_When_DragAndDropDragMe()
        {
          

            var colorBefore = _droppablePage.DropHere.GetCssColor();

            Builder.DragAndDrop(_droppablePage.DragMe.WrappedElement, _droppablePage.DropHere.WrappedElement).Perform();
           
           Assert.AreNotEqual(colorBefore, _droppablePage.DropHere.GetCssColor());
        }

        [Test]
        public void TextChanged_When_DragAndDropDragMe()
        {

            var textBefore = _droppablePage.DropHere.Text;
          

            Builder.DragAndDrop(_droppablePage.DragMe.WrappedElement, _droppablePage.DropHere.WrappedElement).Perform();

            Assert.AreNotEqual("Dropped!", textBefore);
        }

        [Test]
        public void TargetColorChanged_When_DragAcceptableElement()
        {
            _droppablePage.AxisRestrictedTab.Click();


            Builder.MoveToElement(_droppablePage.Acceptable.WrappedElement)
                .ClickAndHold()
                .MoveByOffset(1,1)
                .Perform();


           StringAssert.Contains("ui-droppable-active" , _droppablePage.ClassAfterAction.GetCssAtribute());
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
