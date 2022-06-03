using OpenQA.Selenium;
using PrepMajorCore.Hooks;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrepMajorCore.PageObjects
{
    class TwitterHyperlinkPage
    {
        IWebDriver driver;

        private By TwitterHyperlink = By.CssSelector("#main > div.container > div.post_type_exist.clearfix span.a2a_svg.a2a_s__default.a2a_s_twitter > svg");


        public TwitterHyperlinkPage()
        {
            driver = BaseTest.driver;
        }

        public void twitterHyperlink()
        {
            driver.FindElement(TwitterHyperlink).Click();
        }
        public bool TwitterPageDisplayed()
        {
            return driver.Url == ("https://twitter.com/PrepMajor");
        }
    }
}
