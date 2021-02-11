using OpenQA.Selenium;
using SeleniumPOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo_MP
{
    public class SD_CheckoutTwoPage
    {
        private IWebDriver _seleniumDriver;
        private string checkoutTwoUrl = $"{AppConfigReader.BaseURL} + '/checkout-step-two.html'";
        private IWebElement _item => _seleniumDriver.FindElement(By.ClassName("inventory_item_name"));        

        public SD_CheckoutTwoPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void OnTheCheckoutTwoPage()
        {
            _seleniumDriver.Navigate().GoToUrl(checkoutTwoUrl);
        }

        public void ClickOnItem()
        {
            _item.Click();
        }

    }
}
