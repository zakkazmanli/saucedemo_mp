using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SauceDemo_MP.lib.driver_config;
using System;
using TechTalk.SpecFlow;

namespace SauceDemo_MP.lib.steps
{
    [Binding]
    public class SD_CheckoutSteps
    {
        private SharedStepVariables _sharedVariables;
        public SD_CheckoutSteps(SharedStepVariables shared)
        {
            _sharedVariables = shared;
        }

        [Given(@"I am on the checkout page")]
        public void GivenIAmOnTheCheckoutPage()
        {
            _sharedVariables.SD_Website.SD_CheckoutPage.OnTheCheckoutPage();
        }


        //[When(@"I enter a (.*) and (.*)")]
        //[When(@"I enter a ""(.*)"" and ""(.*)""")]
        //public void WhenIEnterAAnd(string firstinput, string secondinput)
        //{
        //    if (firstinput == "firstname")
        //    { SD_Website.SD_CheckoutPage.EnterFirstName(firstinput); }
        //    if (firstinput == "lastname")
        //    { SD_Website.SD_CheckoutPage.EnterLastName(firstinput); }
        //    if (secondinput == "lastname")
        //        { SD_Website.SD_CheckoutPage.EnterLastName(secondinput); }
        //    if (secondinput == "postcode")
        //    { SD_Website.SD_CheckoutPage.EnterPostCode(secondinput); }
        //}


        [When(@"I press ""(.*)""")]
        public void WhenIPress(string button)
        {
            _sharedVariables.SD_Website.SD_CheckoutPage.PressButton(button);
        }

        [Then(@"I land on the Cart Page")]
        public void ThenILandOnTheCartPage()
        {
            Assert.That(_sharedVariables.SD_Website.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/cart.html"));
        }

        [When(@"I fill in the firstname, secondname, postcode")]
        public void IFillInTheFirstnameSecondnamePostcode()
        {
            _sharedVariables.SD_Website.SD_CheckoutPage.EnterFirstName("Sam");
            _sharedVariables.SD_Website.SD_CheckoutPage.EnterLastName("Test");
            _sharedVariables.SD_Website.SD_CheckoutPage.EnterPostCode("12345");
        }


        [Then(@"I land on the Second Checkout Page")]
        public void ThenILandOnTheSecondCheckoutPage()
        {
            Assert.That(_sharedVariables.SD_Website.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/checkout-step-two.html"));
        }

        [Then(@"I should receive the error containing (.*)")]
        public void ThenIShouldReceiveTheErrorContaining(string error)
        {
            Assert.That(_sharedVariables.SD_Website.SD_CheckoutPage.RetrieveErrorMessage(), Does.Contain(error.Trim('\"')));
        }
    }
}
