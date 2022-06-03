using NUnit.Framework;
using OpenQA.Selenium;
using PrepMajorCore.Hooks;
using PrepMajorCore.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrepMajorCore.PageObjects
{
    class BecomeAnInstructorPO
    {
        IWebDriver driver;
        public BecomeAnInstructorPO()
        {
            driver = BaseTest.driver;
        }

        Waits waits = new Waits();

        IWebElement becomeInstructorLink => driver.FindElement(By.CssSelector("div.center-unit > div.stm_header_links > a:nth-child(1) > span"));
        
        IWebElement degreeField => driver.FindElement(By.CssSelector("#stm-lms-become-instructor form > div:nth-child(1) > input"));
        IWebElement expertiseField => driver.FindElement(By.CssSelector("#stm-lms-become-instructor > div > form > div:nth-child(2) > input"));
        IWebElement sendApplicationButton => driver.FindElement(By.CssSelector("#stm-lms-become-instructor > div > form > button > span"));
        IWebElement successMessage => driver.FindElement(By.CssSelector("#stm-lms-become-instructor > div.stm-lms-message.success"));
        IWebElement errorMessage => driver.FindElement(By.CssSelector("#stm-lms-become-instructor > div.stm-lms-message.error"));
        IWebElement userIcon => driver.FindElement(By.CssSelector("div.stm_lms_user_float_menu__user_avatar"));
        IWebElement usernameHeader => driver.FindElement(By.XPath("//*[@id='main']/div/div/div/div/div[1]/div[1]/h3"));

        public void ClickBecomeInstuctor()
        {
           becomeInstructorLink.Click();
        }

        
        public void EnterDetails(string degree, string expertise)
        {
            degreeField.SendKeys(degree);
            expertiseField.SendKeys(expertise);
            
        }

        public void ErrorMessage(string errMessage)
        {
            waits.WaitForElement(driver, errorMessage);
            Assert.IsTrue(errorMessage.Displayed);
            Assert.AreEqual(errMessage, errorMessage.Text);
        }

    

        public void SuccessMessage(string message)
        {
            waits.WaitForElement(driver, successMessage);
            Assert.IsTrue(successMessage.Displayed);
            Assert.AreEqual(message, successMessage.Text);
        }

        public void UserIcon()
        {
            userIcon.Click();
        }

        public void ProfilePage()
        {
            waits.WaitForElement(driver, usernameHeader);
            Assert.IsTrue(usernameHeader.Displayed);
           
        }

        public void ClickSendApplication()
        {
            sendApplicationButton.Click();
        }

       
    }
}
