using OpenQA.Selenium;
using PrepMajorCore.Hooks;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrepMajorCore.PageObjects
{
   
    class InstructorButtonPage
    {

        public IWebDriver driver;

        private By BecomeAnInstructorButton = By.CssSelector("#header > div > div.container > div > div > div > div.center-unit > div.stm_header_links > a:nth-child(1) > span");

        public void Navigate(String url)
        {
            driver.Navigate().GoToUrl(url);

        }



        public InstructorButtonPage()
        {
            driver = BaseTest.driver;
        }

        public void InstructorButton()
        {
            driver.FindElement(BecomeAnInstructorButton).Click();
        }


        public bool IsFormDisplayed()
        {
            return driver.Url == ("https://courses.prepmajor.com/become-an-instructor/");

        }
    }
}
