using NUnit.Framework;
using OpenQA.Selenium;
using PrepMajorCore.Hooks;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrepMajorCore.PageObjects
{
    class LoginPage
    {
        IWebDriver driver;

        IWebElement loginField => driver.FindElement(By.CssSelector("div.right-unit > a.stm_lms_log_in > span"));
        IWebElement userName => driver.FindElement(By.CssSelector("div.stm_lms_login_wrapper div:nth-child(1) > input"));
        IWebElement password => driver.FindElement(By.CssSelector("div.stm_lms_login_wrapper > div:nth-child(2) > input"));
        IWebElement rememberMe => driver.FindElement(By.CssSelector("#stm-lms-login span.stm_lms_styled_checkbox__inner > input[type=checkbox]"));
        IWebElement loginButton => driver.FindElement(By.CssSelector("div.stm_lms_login_wrapper__actions > a > span"));
        

        IWebElement forEnterprise => driver.FindElement(By.CssSelector("#header > div > div.container div.stm_header_links > a > span"));

        IWebElement errorMesage => driver.FindElement(By.CssSelector("#stm-lms-login-modal > div.stm-lms-message.error"));


        public LoginPage()
        {
            driver = BaseTest.driver;
        }

        public void ClickLoginField()
        {
            loginField.Click();
        }

        public void EnterUserName(string name)
        {
            userName.SendKeys(name);
        }

        public void EnterPassword(string userpassword)
        {
            password.SendKeys(userpassword);
        }

        public void TickRememberMe()
        {
            rememberMe.Click();
        }

        public void ClickLoginButton()
        {
           loginButton.Click();
        }

        public void ForEnterpriseIsDisplayed()
        {
            Assert.IsTrue(forEnterprise.Displayed);
        }

        

        public void ErrorMessageIsDisplayed()
        
        {
            Assert.IsTrue(errorMesage.Displayed);
        }
    }
}
