using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace DotNetTraining
{
    internal class WebDriverFactory
    {
        public WebDriverFactory()
        {

        }

        public IWebDriver Create(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    return GetChromeDriver();
                case BrowserType.FireFox:
                    return GetFireFoxDriver();
                default:
                    throw new ArgumentOutOfRangeException("No such browser exists");
            }
            
        }

        private IWebDriver GetFireFoxDriver()
        {
            var options = new FirefoxOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("--ignore-certificate-errors");
            return new FirefoxDriver(options);
        }

        private IWebDriver GetChromeDriver()
        {
                var options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                options.AddArgument("--ignore-certificate-errors");
                return new ChromeDriver(options);
        }
    }
}