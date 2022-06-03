using PrepMajorCore.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace PrepMajorCore.StepDefinitions
{
    [Binding]
    public class CustomizedDomainSteps
    {
        CustomizedDomainPage customizeddomainPage;

        public CustomizedDomainSteps()
    
        {
            customizeddomainPage = new CustomizedDomainPage();
        }

        [When(@"a user click pricing")]
        public void WhenAUserClickPricing()
        {
            customizeddomainPage.ClickPricing();
        }

        [When(@"a user click on request a quote")]
        public void WhenAUserClickOnRequestAQuote()
        {
            customizeddomainPage.ClickRequestAQuote();
        }

        [When(@"a user enter first and last name ""(.*)""")]
        public void WhenAUserEnterFirstAndLastName(string username)
        {
            customizeddomainPage.EnterFirstAndLastName(username);
        }

        [When(@"a user enter company email address ""(.*)""")]
        public void WhenAUserEnterCompanyEmailAddress(string companyemail)
        {
            customizeddomainPage.EnterCompanyEmailAddress(companyemail);
        }

        [When(@"a user enter company name ""(.*)""")]
        public void WhenAUserEnterCompanyName(string name)
        {
            customizeddomainPage.EnterCompanyName(name);
        }

        [When(@"a user enter phone number ""(.*)""")]
        public void WhenAUserEnterPhoneNumber(string mobile)
        {
            customizeddomainPage.EnterPhoneNumber(mobile);
        }

        [When(@"a user enter country ""(.*)""")]
        public void WhenAUserEnterCountry(string countryname)
        {
            customizeddomainPage.EnterCountry(countryname);
        }

        [When(@"a user select book a free demo ""(.*)""")]
        public void WhenAUserSelectBookAFreeDemo(string demo)
        {
            customizeddomainPage.EnterFreeDemo(demo);
        }

        [When(@"a user select do you want to book a meeting now ""(.*)""")]
        public void WhenAUserSelectDoYouWantToBookAMeetingNow(string bookmeeting)
        {
            customizeddomainPage.EnterBookMeeting(bookmeeting);
        }

        [When(@"a user briefly describe his need ""(.*)""")]
        public void WhenAUserBrieflyDescribeHisNeed(string companyneed)
        {
            customizeddomainPage.EnterNeed(companyneed);
        }

        [When(@"a user click on submit button")]
        public void WhenAUserClickOnSubmitButton()
        {
            customizeddomainPage.ClickSubmitButton();
        }


    }
}
