using System;
using OpenQA.Selenium;

namespace DotNetTraining
{
    class HomePage : BasePage
    {

        public HomePage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public IWebElement siteDescriptionTitle => Driver.FindElement(By.CssSelector("#editorial_block_center h1"));


        internal void GoTo()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
    }
}