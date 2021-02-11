using OpenQA.Selenium;
using SeleniumPOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo_MP
{
    public class SD_SignInPage
    {
        private IWebDriver _seleniumDriver;

        private string _signInPageURL = AppConfigReader.BaseURL;

        private IWebElement _username => _seleniumDriver.FindElement(By.Id("user-name"));

        private IWebElement _password => _seleniumDriver.FindElement(By.Id("password"));

        private IWebElement _loginButton => _seleniumDriver.FindElement(By.Id("login-button"));

        public SD_SignInPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void NavigateToSignInPage() => _seleniumDriver.Navigate().GoToUrl(_signInPageURL);

        public void EnterUsernameAndPassword(string username, string password)
        {
            _username.SendKeys(username);
            _password.SendKeys(password);
        }

        public void ClickLoginButton() => _loginButton.Click();

        public string RetrieveErrorMessage()
        {
            try
            {
                return _seleniumDriver.FindElement(By.CssSelector("*[data-test=\"error\"]")).Text;
            }
<<<<<<< HEAD
            catch(NoSuchElementException e)
=======
            catch (NoSuchElementException e)
>>>>>>> d8c99825674729a9f8f7e07a4afb1d125405b0e0
            {
                return "";
            }
        }
<<<<<<< HEAD
        
=======

>>>>>>> d8c99825674729a9f8f7e07a4afb1d125405b0e0
        public void ClickErrorMessageButton() => _seleniumDriver.FindElement(By.ClassName("error-button")).Click();
    }
}
