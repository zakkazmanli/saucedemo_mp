using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using System.Threading;
using SauceDemo_MP.lib.driver_config;

namespace SauceDemo_MP.lib.tests
{
    [Binding]
    public class SD_CartSteps
    {
        private string _productName;

        private SharedStepVariables _sharedVariables;
        public SD_CartSteps(SharedStepVariables shared)
        {
            _sharedVariables = shared;
        }

        [Given(@"I click the ""(.*)"" add to cart button")]
        public void GivenIClickTheAddToCartButton(string productName)
        {
            _sharedVariables.SD_Website.SD_ProductsPage.GoToProductsPage();
            _sharedVariables.SD_Website.SD_ProductsPage.AddItemToCart();
        }

        [Given(@"I go to the cart page")]
        public void GivenIGoToTheCartPage()
        {
            _sharedVariables.SD_Website.SD_ProductPage.GoToCartPage();
        }
        
        [When(@"I click the checkout button")]
        public void WhenIClickTheCheckoutButton()
        {
            _sharedVariables.SD_Website.SD_CartPage.ClickCheckoutButton();
        }

        [When(@"I click remove for the product ""(.*)""")]
        public void WhenIClickRemoveForTheProduct(string productName)
        {
            _productName = productName;
            _sharedVariables.SD_Website.SD_CartPage.ClickProductRemove(productName);
        }

        [When(@"I click the continue shopping button")]
        public void WhenIClickTheContinueShoppingButton()
        {
            _sharedVariables.SD_Website.SD_CartPage.ClickContinueShoppingButton();
        }

        [Then(@"I should land on the products page")]
        public void ThenIShouldLandOnTheProductsPage()
        {
            Assert.That(_sharedVariables.SD_Website.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }


        [Then(@"I should no longer see that item in my cart")]
        public void ThenIShouldNoLongerSeeThatItemInMyCart()
        {
            Assert.That(_sharedVariables.SD_Website.SD_CartPage.GetCardItemByName(_productName), Is.Null);
        }

        [Then(@"I should be on the checkout page")]
        public void ThenIShouldBeOnTheCheckoutPage()
        {
            Assert.That(_sharedVariables.SD_Website.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/checkout-step-one.html"));
        }
    }
}
