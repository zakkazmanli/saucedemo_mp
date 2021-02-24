using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SauceDemo_MP.lib.driver_config;
using System;
using TechTalk.SpecFlow;

namespace SauceDemo_MP.lib.tests
{
    [Binding]
    public class SD_CheckoutTwoSteps
    {
        private SharedStepVariables _sharedVariables;
        public SD_CheckoutTwoSteps(SharedStepVariables shared)
        {
            _sharedVariables = shared;
        }

        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn()
        {
            _sharedVariables.SD_Website.SD_SignInPage.NavigateToSignInPage();
            _sharedVariables.SD_Website.SD_SignInPage.EnterUsernameAndPassword("standard_user", "secret_sauce");
            _sharedVariables.SD_Website.SD_SignInPage.ClickLoginButton();
        }

        [Given(@"I am on the checkout two page")]
        [When(@"I go to the checkout two page")]
        public void IGoToTheCheckoutTwoPage()
        {
            _sharedVariables.SD_Website.SD_CheckoutTwoPage.OnTheCheckoutTwoPage();
        }

        [When(@"I press on the Item")]
        public void WhenIPressOnTheItem()
        {
            _sharedVariables.SD_Website.SD_CheckoutTwoPage.ClickOnItem();
        }


        [Then(@"I land on the Products Page")]
        public void ThenILandOnTheProductsPage()
        {
            Assert.That(_sharedVariables.SD_Website.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }
        
        [Then(@"I land on the Checkout Complete Page")]
        public void ThenILandOnTheCheckoutCompletePage()
        { 
            Assert.That(_sharedVariables.SD_Website.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/checkout-complete.html"));
        }
    }
}
