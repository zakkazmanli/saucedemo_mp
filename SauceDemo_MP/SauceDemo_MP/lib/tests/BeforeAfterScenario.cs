using SauceDemo_MP.lib.driver_config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SauceDemo_MP.lib.tests
{
    [Binding]
    public sealed class BeforeAfterScenario
    {
        private SharedStepVariables _sharedVariables;
        public BeforeAfterScenario(SharedStepVariables shared)
        {
            _sharedVariables = shared;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _sharedVariables.SD_Website.SeleniumDriver.Dispose();
        }
    }
}
