using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetTraining
{
    [TestClass]
    public class HomePageTests : BaseTest
    {


        [TestMethod]
        public void CheckHomepageLoads()
        {            
            HomePage.GoTo();
            Assert.AreEqual("Automation Practice Website", HomePage.SiteDescriptionTitle.Text);
        }

        [TestMethod]
        public void SearchFunctionalityReturnsSomeResults()
        {
            HomePage.GoTo();
            HomePage.SearchItem("dress");

            var getSearchResult = HomePage.SearchResults.Text;

            if (getSearchResult.StartsWith("1"))
            {
                Assert.AreEqual(getSearchResult, "1 result has been found.");
            } else
                Assert.IsTrue(getSearchResult.Contains("results have been found."));                                                        
        }


        [TestMethod]
        public void SearchReturnsNoResults() {
           
            HomePage.GoTo();
            HomePage.SearchItem("assd!");

            var getSearchResult = HomePage.NoSearchResults.Text;
            if (getSearchResult.StartsWith("0"))
            {
                Assert.AreEqual(getSearchResult, "0 results have been found.");
            }
            
        }

        [TestMethod]
        public void CheckSlider()
        {
            HomePage.GoTo();
            var getFirstSliderImage = HomePage.Slider.CurrentImage.GetAttribute("style");
            HomePage.Slider.ClickNextButton();
            var getSecondSliderImage = HomePage.Slider.CurrentImage.GetAttribute("style");

            Assert.AreNotEqual(getSecondSliderImage, getFirstSliderImage);
        }



    }
}
