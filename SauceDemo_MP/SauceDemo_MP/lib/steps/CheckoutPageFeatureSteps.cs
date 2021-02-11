using System;
using TechTalk.SpecFlow;

namespace SauceDemo_MP.lib.steps
{
    [Binding]
    public class CheckoutPageFeatureSteps
    {
        [Given(@"I am on the checkout page")]
        public void GivenIAmOnTheCheckoutPage()
        {
            //SD_Website.SD_CheckoutPage.OnTheCheckoutPage();
        }
        
        [When(@"I press ""(.*)""")]
        public void WhenIPress(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I get an error saying ""(.*)""")]
        public void ThenIGetAnErrorSaying(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
