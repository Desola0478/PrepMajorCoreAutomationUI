using OpenQA.Selenium;
using PrepMajorCore.Hooks;
using PrepMajorCore.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrepMajorCore.PageObjects
{
    class CustomizedDomainPage
    {
        IWebDriver driver;

        Waits waits = new Waits();

        IWebElement pricing => driver.FindElement(By.CssSelector("#menu-item-587 > a"));
        IWebElement requestAQuote => driver.FindElement(By.XPath("/html/body//div[2]/div/div[1]/div/div[7]/a[1]"));
        IWebElement firstAndLastName => driver.FindElement(By.XPath("/html//form/p[1]/label/span/input"));
        IWebElement companyEmailAddress => driver.FindElement(By.CssSelector("p:nth-child(3) > label > span > input"));
        IWebElement companyName => driver.FindElement(By.CssSelector("p:nth-child(4) > label > span > input"));
        IWebElement phoneNumber => driver.FindElement(By.CssSelector("p:nth-child(5) > label > span > input"));
        IWebElement country => driver.FindElement(By.CssSelector("p:nth-child(6) > label > span > input"));
        IWebElement freeDemo => driver.FindElement(By.CssSelector("#wpcf7-f1475-p1061-o1 > form > p:nth-child(7) > label"));
        IWebElement meeting => driver.FindElement(By.XPath("//div/div/div[2]/div/form/p[7]/label/span/select"));
        IWebElement need => driver.FindElement(By.CssSelector("p:nth-child(9) > label > span > textarea"));
        IWebElement submitButton => driver.FindElement(By.CssSelector("p:nth-child(10) > input"));

        public CustomizedDomainPage()
        {
            driver = BaseTest.driver;
        }


        public void ClickPricing()
        {
            pricing.Click();
        }

        public void ClickRequestAQuote()
        {
            //var element = requestAQuote;
            //var script = "arguments[0].scrollIntoView(true);";
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript(script, element);

           

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", requestAQuote);

            waits.WaitForElement(driver, requestAQuote).Click();
        }

        public void EnterFirstAndLastName(string username)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", firstAndLastName);
            waits.WaitForElement(driver, firstAndLastName).SendKeys(username);

        }

        public void EnterCompanyEmailAddress(string companyemail)
        {
            companyEmailAddress.SendKeys(companyemail);
        }

        public void EnterCompanyName(string name)
        {
            companyName.SendKeys(name);
        }

        public void EnterPhoneNumber(string mobile)
        {
            phoneNumber.SendKeys(mobile);
        }

        public void EnterCountry(string countryname)
        {
            country.SendKeys(countryname);
        }

        public void EnterFreeDemo(string demo)
        {
            freeDemo.SendKeys(demo);
        }

        public void EnterBookMeeting(string bookmeeting)
        {
            meeting.SendKeys(bookmeeting);
        }

        public void EnterNeed(string companyneed)
        {
            need.SendKeys(companyneed);
        }

        public void ClickSubmitButton()
        {
           submitButton.Click();
        }


    }
}
