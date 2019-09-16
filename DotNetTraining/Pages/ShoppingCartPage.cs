using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining.Pages
{
    class ShoppingCartPage : BasePage
    {

        public ShoppingCartPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;  
        }

        public IWebElement ShoppingCartPageTitle => Driver.FindElement(By.CssSelector("#cart_title"));
    }
}
