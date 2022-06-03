using OpenQA.Selenium;
using PrepMajorCore.Hooks;
using PrepMajorCore.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace PrepMajorCore.StepDefinitions
{
    [Binding]
    public class TwitterHyperlinkSteps
    {

        public IWebDriver driver = BaseTest.driver;
        TwitterHyperlinkPage twitterHyperlinkPage = new TwitterHyperlinkPage();

        
        
        [Given(@"User clicks on twitter icon hyperlink")]
        public void GivenUserClicksOnTwitterIconHyperlink()
        {
            twitterHyperlinkPage.twitterHyperlink();
        }
        
        [Then(@"twitter page is displayed")]
        public void ThenTwitterPageIsDisplayed()
        {
            twitterHyperlinkPage.TwitterPageDisplayed();
        }
    }
}
