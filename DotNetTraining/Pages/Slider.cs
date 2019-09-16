using System;
using OpenQA.Selenium;

namespace DotNetTraining
{
    public class Slider : BasePage
    {

        public Slider(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public IWebElement CurrentImage => Driver.FindElement(By.CssSelector("#homeslider"));

        public IWebElement NextButton => Driver.FindElement(By.CssSelector("#homepage-slider .bx-next"));

        internal void ClickNextButton()
        {
            NextButton.Click();
        }

    }
}