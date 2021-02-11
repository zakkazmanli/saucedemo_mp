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
        
        [Given(@"I click (.*)")]
        public void GivenIClick(string productName)
        {
            // click on the specified product name
        }

        [Given(@"There are no items in my cart")]
        public void GivenThereAreNoItemsInMyCart()
        {
            Assert.That(SD_Website.SD_ProductPage.GetNumberofItemsInCart(), Is.EqualTo(0));
        }

        [When(@"I click the add to cart button")]
        public void WhenIClickTheAddToCartButton()
        {
            SD_Website.SD_ProductPage.AddItemToCartClick();
        }
        
        [Then(@"the cart number size increases by one")]
        public void ThenTheCartNumberSizeIncreasesByOne()
        {
            Assert.That(SD_Website.SD_ProductPage.GetNumberofItemsInCart(), Is.EqualTo(1));
        }
        
        [Then(@"the add to cart button changes to remove")]
        public void ThenTheAddToCartButtonChangesToRemove()
        {
            Assert.That(SD_Website.SD_ProductPage.GetRemoveFromCartButtonText(), Is.Not.Null);
            Assert.That(SD_Website.SD_ProductPage.GetRemoveFromCartButtonText().ToLower(), Is.EqualTo("remove"));
        }
    }
}
