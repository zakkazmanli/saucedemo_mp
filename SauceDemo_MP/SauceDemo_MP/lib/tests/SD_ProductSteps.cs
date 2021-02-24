using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SauceDemo_MP.lib.driver_config;
using System;
using TechTalk.SpecFlow;

namespace SauceDemo_MP.lib.tests
{
    [Binding]
    public class SD_ProductSteps
    {
        private int _itemsInCart;

        private SharedStepVariables _sharedVariables;
        public SD_ProductSteps(SharedStepVariables shared)
        {
            _sharedVariables = shared;
        }


        [Given(@"I click the (.*) product button")]
        public void GivenIClickTheProductButton(string productName)
        {
            _sharedVariables.SD_Website.SD_ProductsPage.ClickProductName(productName);
        }

        [Given(@"I have signed in as ""(.*)"" with the password ""(.*)""")]
        public void GivenIHaveSignedInAsWithThePassword(string username, string password)
        {
            _sharedVariables.SD_Website.SD_SignInPage.NavigateToSignInPage();
            _sharedVariables.SD_Website.SD_SignInPage.EnterUsernameAndPassword(username, password);
            _sharedVariables.SD_Website.SD_SignInPage.ClickLoginButton();
        }

        [Given(@"There are no items in my cart")]
        public void GivenThereAreNoItemsInMyCart()
        {
            _itemsInCart = 0;
            Assert.That(_sharedVariables.SD_Website.SD_ProductPage.GetNumberofItemsInCart(), Is.EqualTo(0));
        }

        [Given(@"There are ""(.*)"" items in my cart")]
        public void GivenThereAreItemsInMyCart(int numberOfItemsInCart)
        {
            _itemsInCart = numberOfItemsInCart;
            Assert.That(_sharedVariables.SD_Website.SD_ProductPage.GetNumberofItemsInCart(), Is.EqualTo(numberOfItemsInCart));
        }

        [Given(@"I click the add to cart button")]
        [When(@"I click the add to cart button")]
        public void IClickTheAddToCartButton()
        {
            _sharedVariables.SD_Website.SD_ProductPage.AddOrRemoveButtonClick();
        }

        [When(@"I click the remove button")]
        public void WhenIClickTheRemoveButton()
        {
            _sharedVariables.SD_Website.SD_ProductPage.AddOrRemoveButtonClick();
        }

        [When(@"I click the back button")]
        public void WhenIClickTheBackButton()
        {
            _sharedVariables.SD_Website.SD_ProductPage.GoBackToProductsList();
        }

        [Then(@"the cart number size decreases by one")]
        public void ThenTheCartNumberSizeDecreasesByOne()
        {
            Assert.That(_sharedVariables.SD_Website.SD_ProductPage.GetNumberofItemsInCart(), Is.EqualTo(_itemsInCart - 1));
        }

        [Then(@"the remove button changes to add to cart")]
        public void ThenTheRemoveButtonChangesToAddToCart()
        {
            Assert.That(_sharedVariables.SD_Website.SD_ProductPage.GetAddOrRemoveButtonText().ToLower(), Is.EqualTo("add to cart"));
        }

        [Then(@"I should be on the products page")]
        public void ThenIShouldBeOnTheProductsPage()
        {
            Assert.That(_sharedVariables.SD_Website.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }

        [Then(@"the cart number size increases by one")]
        public void ThenTheCartNumberSizeIncreasesByOne()
        {
            Assert.That(_sharedVariables.SD_Website.SD_ProductPage.GetNumberofItemsInCart(), Is.EqualTo(_itemsInCart + 1));
        }
        
        [Then(@"the add to cart button changes to remove")]
        public void ThenTheAddToCartButtonChangesToRemove()
        {
            Assert.That(_sharedVariables.SD_Website.SD_ProductPage.GetAddOrRemoveButtonText().ToLower(), Is.EqualTo("remove"));
        }
    }
}
