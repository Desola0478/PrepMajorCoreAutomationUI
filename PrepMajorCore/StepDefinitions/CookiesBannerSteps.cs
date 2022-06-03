using PrepMajorCore.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace PrepMajorCore.StepDefinitions
{
    [Binding]
    public class CookiesBannerSteps
    {
         ContactUsPage contactusPage;

        public CookiesBannerSteps()
        {
            contactusPage = new ContactUsPage();
        }

        [When(@"a user click on accept all cookies")]
        public void WhenAUserClickOnAcceptAllCookies()
        {
            contactusPage.ClickAcceptCookies();
        }


        [Then(@"user can effectively use the website")]
        public void ThenUserCanEffectivelyUseTheWebsite()
        {
            contactusPage.PrepMajorLogoIsDisplayed();
        }

        [When(@"a user click on manage cookies")]
        public void WhenAUserClickOnManageCookies()
        {
            contactusPage.ClickManageCookies();
        }

        [When(@"a user enable functional cookies")]
        public void WhenAUserEnableFunctionalCookies()
        {
            contactusPage.EnableFunctionalCookies();
        }

        [When(@"a user enable analytics cookies")]
        public void WhenAUserEnableAnalyticsCookies()
        {
            contactusPage.EnableAnalyticsCookies();
        }

        [When(@"a user click on save & accept")]
        public void WhenAUserClickOnSaveAccept()
        {
            contactusPage.ClickSaveAndAccept();
        }

        [Then(@"user can see about us on the website")]
        public void ThenUserCanSeeAboutUsOnTheWebsite()
        {
            contactusPage.AboutUsIsDisplayed();
        }


    }
}
