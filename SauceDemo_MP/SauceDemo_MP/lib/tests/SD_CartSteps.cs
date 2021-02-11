using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace SauceDemo_MP.lib.tests
{
    [Binding]
    public class SD_CartSteps
    {
        private SD_Website<ChromeDriver> SD_Website;

        [BeforeScenario]
        public void SetUp()
        {
            SD_Website = new SD_Website<ChromeDriver>();
        }

        private string _productName;

        [Given(@"I click the ""(.*)"" add to cart button")]
        public void GivenIClickTheAddToCartButton(string productName)
        {
            //ScenarioContext.Current.Pending();
        }

        [Given(@"I go to the cart page")]
        public void GivenIGoToTheCartPage()
        {
            SD_Website.SD_ProductPage.GoToCheckout();
        }
        
        [When(@"I click the checkout button")]
        public void WhenIClickTheCheckoutButton()
        {
            SD_Website.SD_CartPage.ClickCheckoutButton();
        }

        [When(@"I click remove for the product ""(.*)""")]
        public void WhenIClickRemoveForTheProduct(string productName)
        {
            _productName = productName;
            SD_Website.SD_CartPage.ClickProductRemove(productName);
        }

        [When(@"I click the continue shopping button")]
        public void WhenIClickTheContinueShoppingButton()
        {
            SD_Website.SD_CartPage.ClickContinueShoppingButton();
        }


        [Then(@"I should no longer see that item in my cart")]
        public void ThenIShouldNoLongerSeeThatItemInMyCart()
        {
            Assert.Throws<NoSuchElementException>(() => SD_Website.SD_CartPage.GetCardItemByName(_productName));
        }

        [Then(@"I should be on the checkout page")]
        public void ThenIShouldBeOnTheCheckoutPage()
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }

        [AfterScenario]
        public void TearDown()
        {
            SD_Website.SeleniumDriver.Dispose();
            SD_Website.SeleniumDriver.Quit();
        }
    }
}
