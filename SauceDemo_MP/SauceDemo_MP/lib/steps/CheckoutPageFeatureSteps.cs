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
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I fill in the firstname, secondname, postcode")]
        public void GivenIFillInTheFirstnameSecondnamePostcode()
        {
            ScenarioContext.Current.Pending();
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
        
        [Then(@"I land on the Cart Page")]
        public void ThenILandOnTheCartPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I land on the Second Checkout Page")]
        public void ThenILandOnTheSecondCheckoutPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
