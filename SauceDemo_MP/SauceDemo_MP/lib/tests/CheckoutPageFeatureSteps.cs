﻿using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SauceDemo_MP.lib.steps
{
    [Binding]
    public class CheckoutPageFeatureSteps
    {
        private SD_Website<ChromeDriver> SD_Website;

        [BeforeScenario]
        public void SetUp()
        {
            SD_Website = new SD_Website<ChromeDriver>();
        }

        [Given(@"I am on the checkout page")]
        public void GivenIAmOnTheCheckoutPage()
        {
            SD_Website.SD_SignInPage.NavigateToSignInPage();
            SD_Website.SD_SignInPage.EnterUsernameAndPassword("standard_user", "secret_sauce");
            SD_Website.SD_SignInPage.ClickLoginButton();
            SD_Website.SD_CheckoutPage.OnTheCheckoutPage();
        }

        [Given(@"I enter a ""(.*)"" and ""(.*)""")]
        public void GivenIEnterAAnd(string firstinput, string secondinput)
        {
            if (firstinput == "firstname")
            { SD_Website.SD_CheckoutPage.EnterFirstName(firstinput); }
            if (firstinput == "lastname")
            { SD_Website.SD_CheckoutPage.EnterLastName(firstinput); }
            if (secondinput == "lastname")
                { SD_Website.SD_CheckoutPage.EnterLastName(secondinput); }
            if (secondinput == "postcode")
            { SD_Website.SD_CheckoutPage.EnterPostCode(secondinput); }
        }


        [When(@"I press ""(.*)""")]
        public void WhenIPress(string button)
        {
            SD_Website.SD_CheckoutPage.PressButton(button);
        }
        
        [Then(@"I get an error saying ""(.*)""")]
        public void ThenIGetAnErrorSaying(string expected)
        {
            Assert.That(SD_Website.SD_CheckoutPage.EmptyFieldsAlert().Contains(expected));

        }

        [Then(@"I land on the Cart Page")]
        public void ThenILandOnTheCartPage()
        {
            Assert.That(SD_Website.SD_CheckoutPage.Subheader().Contains("Your Cart"));
        }

        [Given(@"I fill in the firstname, secondname, postcode")]
        public void GivenIFillInTheFirstnameSecondnamePostcode()
        {
            SD_Website.SD_CheckoutPage.EnterFirstName("Sam");
            SD_Website.SD_CheckoutPage.EnterLastName("Test");
            SD_Website.SD_CheckoutPage.EnterPostCode("12345");
        }

        [Then(@"I land on the Second Checkout Page")]
        public void ThenILandOnTheSecondCheckoutPage()
        {
            Assert.That(SD_Website.SD_CheckoutPage.Subheader().Contains("Checkout: Overview"));
        }


        [AfterScenario]
        public void TearDown()
        {
            SD_Website.SeleniumDriver.Dispose();
            SD_Website.SeleniumDriver.Quit();
        }
    }
}