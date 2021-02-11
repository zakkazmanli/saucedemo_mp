using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo_MP.lib.pages
{
    public class SD_ProductPage
    {
        private IWebDriver _seleniumDriver;

        public SD_ProductPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        private IWebElement _cart => _seleniumDriver.FindElement(By.Id("shopping_cart_container"));
        private IWebElement _addRemoveToCartButtons => _seleniumDriver.FindElement(By.ClassName("btn_inventory"));
        private IWebElement _cartBadgeNumber => _seleniumDriver.FindElement(By.ClassName("shopping_cart_badge"));
        private IWebElement _backButton => _seleniumDriver.FindElement(By.ClassName("inventory_details_back_button"));

        public void GoToCheckout() => _cart.Click();
        public int GetNumberofItemsInCart()
        {
            try
            {
                return int.Parse(_cartBadgeNumber.Text);
            }
            catch (OpenQA.Selenium.NoSuchElementException)
            {
                return 0;
            }
        }

        public void GoBackToProductsList() => _backButton.Click();
        public void AddOrRemoveButtonClick() => _addRemoveToCartButtons.Click();
        public string GetAddOrRemoveButtonText() => _addRemoveToCartButtons.Text;
    }
}
