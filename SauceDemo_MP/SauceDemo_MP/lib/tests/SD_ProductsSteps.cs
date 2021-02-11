using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SauceDemo_MP.lib.tests
{
    [Binding]
    public class SD_ProductsSteps
    {
        private SD_Website<ChromeDriver> SD_Website;

        [BeforeScenario]
        public void SetUp()
        {
            SD_Website = new SD_Website<ChromeDriver>();
        }

        [Given(@"I am on the products page")]
        public void GivenIAmOnTheProductsPage()
        {
            SD_Website.SD_ProductsPage.GoToProductsPage();
        }
        
        [When(@"I select Price \(low to high\)")]
        public void WhenISelectPriceLowToHigh()
        {
            SD_Website.SD_ProductsPage.FilterProducts("lohi");
        }
        
        [Then(@"the products are ordered in ascending price order")]
        public void ThenTheProductsAreOrderedInAscendingPriceOrder()
        {
            Assert.That(SD_Website.SD_ProductsPage.GetListOfProductsPrices(), Is.Ordered.Ascending);
        }

        [When(@"I select Price \(high to low\)")]
        public void WhenISelectPriceHighToLow()
        {
            SD_Website.SD_ProductsPage.FilterProducts("hilo");
        }

        [Then(@"the products are ordered in descending price order")]
        public void ThenTheProductsAreOrderedInDescendingPriceOrder()
        {
            Assert.That(SD_Website.SD_ProductsPage.GetListOfProductsPrices(), Is.Ordered.Descending);
        }


        [AfterScenario]
        public void TearDown()
        {
            SD_Website.SeleniumDriver.Dispose();
            SD_Website.SeleniumDriver.Quit();
        }
    }
}
