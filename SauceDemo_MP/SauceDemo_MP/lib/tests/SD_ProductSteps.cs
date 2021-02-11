using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SauceDemo_MP.lib.tests
{
    [Binding]
    public class SD_ProductSteps
    {
        private SD_Website<ChromeDriver> SD_Website;
        private int _itemsInCart;

        [BeforeScenario]
        public void SetUp()
        {
            SD_Website = new SD_Website<ChromeDriver>();
        }

        [Given(@"I have signed in as ""(.*)"" with the password ""(.*)""")]
        public void GivenIHaveSignedInAsWithThePassword(string username, string password)
        {
            SD_Website.SD_SignInPage.NavigateToSignInPage();
            SD_Website.SD_SignInPage.EnterUsernameAndPassword(username, password);
            SD_Website.SD_SignInPage.ClickLoginButton();
        }

        [Given(@"I click the (.*) product button")]
        public void GivenIClickTheProductButton(string productName)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"There are no items in my cart")]
        public void GivenThereAreNoItemsInMyCart()
        {
            _itemsInCart = 0;
            Assert.That(SD_Website.SD_ProductPage.GetNumberofItemsInCart(), Is.EqualTo(0));
        }

        [Given(@"There are ""(.*)"" items in my cart")]
        public void GivenThereAreItemsInMyCart(int numberOfItemsInCart)
        {
            _itemsInCart = numberOfItemsInCart;
            Assert.That(SD_Website.SD_ProductPage.GetNumberofItemsInCart(), Is.EqualTo(numberOfItemsInCart));
        }

        [Given(@"I click the add to cart button")]
        [When(@"I click the add to cart button")]
        public void IClickTheAddToCartButton()
        {
            SD_Website.SD_ProductPage.AddItemToCartClick();
        }

        [When(@"I click the remove button")]
        public void WhenIClickTheRemoveButton()
        {
            SD_Website.SD_ProductPage.RemoveItemFromCartClick();
        }

        [Then(@"the cart number size decreases by one")]
        public void ThenTheCartNumberSizeDecreasesByOne()
        {
            Assert.That(SD_Website.SD_ProductPage.GetNumberofItemsInCart(), Is.EqualTo(_itemsInCart - 1));
        }

        [Then(@"the remove button changes to add to cart")]
        public void ThenTheRemoveButtonChangesToAddToCart()
        {
            Assert.That(SD_Website.SD_ProductPage.GetAddItemToCartButtonText(), Is.Not.Null);
            Assert.That(SD_Website.SD_ProductPage.GetAddItemToCartButtonText().ToLower(), Is.EqualTo("add to cart"));
        }

        [Then(@"the cart number size increases by one")]
        public void ThenTheCartNumberSizeIncreasesByOne()
        {
            Assert.That(SD_Website.SD_ProductPage.GetNumberofItemsInCart(), Is.EqualTo(_itemsInCart + 1));
        }
        
        [Then(@"the add to cart button changes to remove")]
        public void ThenTheAddToCartButtonChangesToRemove()
        {
            Assert.That(SD_Website.SD_ProductPage.GetRemoveFromCartButtonText(), Is.Not.Null);
            Assert.That(SD_Website.SD_ProductPage.GetRemoveFromCartButtonText().ToLower(), Is.EqualTo("remove"));
        }
    }
}
