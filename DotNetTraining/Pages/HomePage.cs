using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace DotNetTraining
{
    public class HomePage : BasePage
    {

        public HomePage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
            Slider = new Slider(driver);
        }

        public Slider Slider { get; internal set; }

        public IWebElement SiteDescriptionTitle => Driver.FindElement(By.CssSelector("#editorial_block_center h1"));
        
        //public IWebElement SiteDescriptionTitle { get
        //    {
        //        return Driver.FindElement(By.CssSelector("#editorial_block_center h1"));
        //    }
        //}
        public IWebElement SearchInput => Driver.FindElement(By.CssSelector(".ac_input"));
        public IWebElement SearchResults => Driver.FindElement(By.CssSelector(".product-listing span:nth-child(2)"));
        public IWebElement NoSearchResults => Driver.FindElement(By.CssSelector(".product-listing span:nth-child(1)"));
        public IWebElement FirstItemReturnedBySearch => Driver.FindElement(By.CssSelector(".product_list li:first-child"));
        public IWebElement NameOfFirstItemReturnedBySearch =>  Driver.FindElement(By.CssSelector(".product_list li:first-child .right-block h5"));
        public IWebElement AddToCartButtonOfFirstElement => Driver.FindElement(By.CssSelector(".product_list li:first-child .right-block .button-container a:first-child"));
        public IWebElement ConfirmationModalName => Driver.FindElement(By.CssSelector("#layer_cart .layer_cart_product h2"));
        public IWebElement ProceedToCheckoutModalButton => Driver.FindElement(By.CssSelector("#layer_cart .layer_cart_cart .button-container a"));

      

        internal void GoTo()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        public void SearchItem(string item)
        {
            SearchInput.SendKeys(item);
            SearchInput.SendKeys(Keys.Enter);
        }

        public void selectFirstElementInTheItemsList() {

            if (FirstItemReturnedBySearch != null)
            {
                Actions action = new Actions(Driver);
                action.MoveToElement(FirstItemReturnedBySearch).Perform();
                AddToCartButtonOfFirstElement.Click();
                Thread.Sleep(3000);

                if (ConfirmationModalName.Text == "Product successfully added to your shopping cart" )
                {
                    ProceedToCheckoutModalButton.Click();
                }
            }
        }
    }
}