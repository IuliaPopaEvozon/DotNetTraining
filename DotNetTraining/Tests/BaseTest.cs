using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining
{
    public class BaseTest
    {
        public IWebDriver Driver { get; private set; }
        public HomePage HomePage { get; set; }

        [TestInitialize]
        public void Setup()
        {
            var factory = new WebDriverFactory();
            Driver = factory.Create(BrowserType.Chrome);

            HomePage = new HomePage(Driver);

        }

        [TestCleanup]
        public void TearDown()
        {
            Driver.Close();
            Driver.Quit();
        }
        

    }
}
