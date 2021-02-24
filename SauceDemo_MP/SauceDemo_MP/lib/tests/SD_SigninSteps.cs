using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SauceDemo_MP.lib.driver_config;
using System;
using TechTalk.SpecFlow;

namespace SauceDemo_MP.lib.tests
{
    [Binding]
    public class SD_SigninSteps
    {
        private SharedStepVariables _sharedVariables; 

        public SD_SigninSteps(SharedStepVariables shared)
        {
            _sharedVariables = shared;
        }

        [Given(@"I am on the sign in page")]
        public void GivenIAmOnTheSignInPage()
        {
            _sharedVariables.SD_Website.SD_SignInPage.NavigateToSignInPage();
        }

        [When(@"I enter a username (.*) and password (.*)")]
        public void WhenIEnterAUsernameAndPassword(string username, string password)
        {
            _sharedVariables.SD_Website.SD_SignInPage.EnterUsernameAndPassword(username, password);
        }

        [When(@"I enter an invalid username of ""(.*)"" and password ""(.*)""")]
        public void WhenIEnterAnInvalidUsernameOfAndPassword(string username, string password)
        {
            _sharedVariables.SD_Website.SD_SignInPage.EnterUsernameAndPassword(username, password);
        }

        [When(@"I enter a username ""(.*)"" and no password")]
        public void WhenIEnterAUsernameAndNoPassword(string username)
        {
            _sharedVariables.SD_Website.SD_SignInPage.EnterUsernameAndPassword(username, "");
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            _sharedVariables.SD_Website.SD_SignInPage.ClickLoginButton();
        }
        
        [Then(@"I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            Assert.That(_sharedVariables.SD_Website.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }

        [When(@"I click the remove error message button")]
        public void WhenIClickTheRemoveErrorMessageButton()
        {
            _sharedVariables.SD_Website.SD_SignInPage.ClickErrorMessageButton();
        }

        [Then(@"I should receive an error containing ""(.*)""")]
        public void ThenIShouldReceiveAnErrorContaining(string error)
        {
            Assert.That(_sharedVariables.SD_Website.SD_SignInPage.RetrieveErrorMessage(), Does.Contain(error));
        }

        //[Then(@"there should be no visible error message")]
        //public void ThenThereShouldBeNoVisibleErrorMessage()
        //{
        //    Assert.That(SD_Website.SD_SignInPage.RetrieveErrorMessage(), Throws.InstanceOf<OpenQA.Selenium.NoSuchElementException>());
        //}

        [Then(@"there should be no visible error message")]
        public void ThenThereShouldBeNoVisibleErrorMessage()
        {
            Assert.That(_sharedVariables.SD_Website.SD_SignInPage.RetrieveErrorMessage(), Is.EqualTo(""));
        }
    }
}
