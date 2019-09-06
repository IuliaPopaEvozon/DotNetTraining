using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetTraining
{
    [TestClass]
    public class HomePageTests : BaseTest
    {
        [TestMethod]
        public void CheckHomepageLoads()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.GoTo();
            Assert.AreEqual("Automation Practice Website", homePage.siteDescriptionTitle.Text);
        }
        
    }
}
