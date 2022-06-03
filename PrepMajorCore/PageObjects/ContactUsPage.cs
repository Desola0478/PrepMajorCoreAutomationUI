using NUnit.Framework;
using OpenQA.Selenium;
using PrepMajorCore.Hooks;
using PrepMajorCore.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrepMajorCore.PageObjects
{
    class ContactUsPage
    {
        IWebDriver driver;

        Waits waits = new Waits();

        IWebElement contactUs => driver.FindElement(By.CssSelector("#menu-item-591 > a"));
        IWebElement name => driver.FindElement(By.CssSelector("p:nth-child(2) > label > span > input"));
        IWebElement emailAddress => driver.FindElement(By.CssSelector("p:nth-child(3) > label > span > input"));
        IWebElement subject => driver.FindElement(By.CssSelector("p:nth-child(4) > label > span > input"));
        IWebElement message => driver.FindElement (By.CssSelector("p:nth-child(5) > label > span > textarea"));
        IWebElement submit => driver.FindElement (By.CssSelector("#wpcf7-f1481-p1479-o1 > form > p:nth-child(6)"));
        IWebElement successfulMessage => driver.FindElement(By.CssSelector("div.wpcf7-response-output"));

        IWebElement noSubject => driver.FindElement(By.CssSelector("p:nth-child(4) > label > span > input"));
        IWebElement errorMessage => driver.FindElement(By.CssSelector("div.wpcf7-response-output"));

        IWebElement acceptAllCookies => driver.FindElement(By.CssSelector("#cookie_action_close_header"));
        IWebElement prepMajorLogo => driver.FindElement(By.CssSelector("img.h-logo__image.h-logo__image_h.logo-image.style-5-image"));

        IWebElement manageCookies => driver.FindElement(By.XPath("/html/body/div[2]/span/div/div[2]/a[1]"));
        IWebElement functionalCookies => driver.FindElement(By.CssSelector("div:nth-child(2) > div.cli-tab-header > div > label"));
        IWebElement analyticsCookies => driver.FindElement(By.CssSelector("div:nth-child(4) > div.cli-tab-header > div > label"));
        IWebElement saveAndAccept => driver.FindElement(By.CssSelector("#wt-cli-privacy-save-btn"));
        IWebElement aboutUs => driver.FindElement(By.CssSelector("#menu-item-588 > a"));

    
        public ContactUsPage()
        {
            driver = BaseTest.driver;
        }

        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickContactUsButton()
        {
           contactUs.Click();
        }

        public void EnterName(string username)
        {
            name.SendKeys(username);
        }

        public void EnterEmailAddress(string useremail)
        {
            emailAddress.SendKeys(useremail);
        }

        public void EnterSubject(string usersubject)
        {
            subject.SendKeys(usersubject);
        }

        public void EnterMessage(string usermessage)
        {
            message.SendKeys(usermessage);
        }

        public void ClickSubmit()
        {
            waits.WaitForElement(driver, submit).Click();
            //submit.Click();
        }

        public void SuccessfulMessageIsDisplayed(string text)
        {
            Assert.IsTrue(successfulMessage.Displayed);
            Assert.IsTrue(successfulMessage.Text == text);
        }

            public void EnterNoSubject()
        {
            noSubject.Click();
        }

        public void ErrorMessageIsDisplayed(string text)
        {
            Assert.IsTrue(errorMessage.Displayed);
            Assert.IsTrue(errorMessage.Text == text);
        }

        public void ClickAcceptCookies()
        {
            acceptAllCookies.Click();
        }

        public void PrepMajorLogoIsDisplayed()
        {
            Assert.IsTrue(prepMajorLogo.Displayed);
        }

        public void ClickManageCookies()
        {
            manageCookies.Click();
        }

        public void EnableFunctionalCookies()
        {
            functionalCookies.Click();
        }

        public void EnableAnalyticsCookies()
        {
            analyticsCookies.Click();
        }

        public void ClickSaveAndAccept()
        {
            saveAndAccept.Click();
        }

        public void AboutUsIsDisplayed()
        {
            Assert.IsTrue(aboutUs.Displayed);
        }

    }

}
