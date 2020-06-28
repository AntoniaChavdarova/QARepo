using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.UI;

namespace AutomationPractice.Core
{
   public  class WebDriver { 


    private IWebDriver _webDriver;
    private WebDriverWait _webDriverWait;

    public IWebDriver WrappedDriver => _webDriver;

    public void Start(Browser browser)
    {
        switch (browser)
        {
            case Browser.Chrome:
                _webDriver = new ChromeDriver(Environment.CurrentDirectory);
                break;
            case Browser.Firefox:
                _webDriver = new FirefoxDriver(Environment.CurrentDirectory);
                break;
            case Browser.Edge:
                _webDriver = new EdgeDriver(Environment.CurrentDirectory);
                break;
            case Browser.Opera:
                _webDriver = new OperaDriver(Environment.CurrentDirectory);
                break;
            case Browser.Safari:
                _webDriver = new SafariDriver(Environment.CurrentDirectory);
                break;
            case Browser.InternetExplorer:
                _webDriver = new InternetExplorerDriver(Environment.CurrentDirectory);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(browser), browser, null);
        }

        _webDriverWait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(30));
    }

    public void Quit()
    {
        _webDriver.Quit();
    }



    public WebElement FindElement(By locator)
    {
        IWebElement nativeWebElement =
            _webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
        WebElement element = new WebElement(_webDriver, nativeWebElement, locator);

        return element;
    }

  

    public void Navigate(string url)
    {
        WrappedDriver.Navigate().GoToUrl(url);
    }
}
}



