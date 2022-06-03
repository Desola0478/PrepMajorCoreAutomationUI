using NUnit.Framework;
using OpenQA.Selenium;
using PrepMajorCore.Hooks;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrepMajorCore.PageObjects
{
    class RegistrationPage
    {
         IWebDriver driver;

        IWebElement signUp => driver.FindElement(By.CssSelector("#header div > div.container a.btn.btn-default > span"));
        IWebElement userName => driver.FindElement(By.CssSelector("div:nth-child(1) > div:nth-child(1) > div > input"));
        IWebElement userEmail => driver.FindElement(By.CssSelector("#stm-lms-register div:nth-child(1) > div:nth-child(2) > div > input"));
        IWebElement password => driver.FindElement(By.CssSelector("#stm-lms-register > form > div:nth-child(2) > div:nth-child(1) > div > input"));
        IWebElement confirmPassword => driver.FindElement( By.CssSelector("#stm-lms-register > form > div:nth-child(2) > div:nth-child(2) > div > input"));
        IWebElement privacyPolicyCheckBox => driver.FindElement(By.CssSelector("form > div:nth-child(3) >div > label > span > input[type=checkbox]"));
        IWebElement register => driver.FindElement(By.CssSelector("form > div:nth-child(3) > div > div > button > span"));
        IWebElement prepmajorLogo => driver.FindElement(By.CssSelector("div.logo-unit > a > img"));


        IWebElement wrongUserEmail => driver.FindElement(By.CssSelector("#stm-lms-register div:nth-child(1) > div:nth-child(2) > div > input"));
        IWebElement errorMessage => driver.FindElement(By.CssSelector("#stm-lms-register > div"));


        public RegistrationPage()
        {
            driver = BaseTest.driver;
        }

        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        
        public void ClickSignUpField()
        {
            signUp.Click();
        }

        public void EnterUserName(string name)
        {
            userName.SendKeys(name);
        }

        public void EnterEmail(string email)
        {
            userEmail.SendKeys(email);
        }

        public void EnterPassword(string userpassword)
        {
            password.SendKeys(userpassword);

        }

        public void EnterConfirmPassword(string confirmuserpassworf)
        {
            confirmPassword.SendKeys(confirmuserpassworf);
        }

        public void TickPrivacyPolicyCheckBox()
        {
            privacyPolicyCheckBox.Click();
        }

        public void ClickRegister()
        {
            register.Click();
        }

        public void PrepMajorLogoIsDisplayed()
        {
           Assert.IsTrue(prepmajorLogo.Displayed);
        }


        public void EnterWrongEmail(string wrongemail)
        {
            wrongUserEmail.SendKeys(wrongemail);
        }

        public void ErrorMessageIsDisplayed(string text)
        {
            Assert.IsTrue(errorMessage.Displayed);
            Assert.IsTrue(errorMessage.Text == text);
        }
    }
}
