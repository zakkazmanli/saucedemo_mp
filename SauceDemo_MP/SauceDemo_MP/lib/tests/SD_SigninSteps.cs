using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SauceDemo_MP.lib.tests
{
    [Binding]
    public class SD_SigninSteps
    {
        private SD_Website<ChromeDriver> SD_Website;

        [BeforeScenario]
        public void SetUp()
        {
            SD_Website = new SD_Website<ChromeDriver>();
        }

        [Given(@"I am on the sign in page")]
        public void GivenIAmOnTheSignInPage()
        {
            SD_Website.SD_SignInPage.NavigateToSignInPage();
        }

        [When(@"I enter a username (.*) and password ""(.*)""")]
        public void WhenIEnterAUsernameAndPassword(string username, string password)
        {
            SD_Website.SD_SignInPage.EnterUsernameAndPassword(username, password);
        }


        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            SD_Website.SD_SignInPage.ClickLoginButton();
        }
        
        [Then(@"I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }
    }
}
