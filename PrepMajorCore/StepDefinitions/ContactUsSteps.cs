using PrepMajorCore.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace PrepMajorCore.StepDefinitions
{
    [Binding]
    public class ContactUsSteps
    {
        ContactUsPage contactusPage;

        public ContactUsSteps()    
        {
            contactusPage = new ContactUsPage();
        }

        [Given(@"that a user navigate to ""(.*)""")]
        public void GivenThatAUserNavigateTo(string url)
        {
            contactusPage.Navigate(url);
        }

        [When(@"a user click contact us button")]
        public void WhenAUserClickContactUsButton()
        {
            contactusPage.ClickContactUsButton();
        }

        [When(@"a user enter name ""(.*)""")]
        public void WhenAUserEnterName(string username)
        {
            contactusPage.EnterName(username);
        }

        [When(@"a user enter email address ""(.*)""")]
        public void WhenAUserEnterEmailAddress(string useremail)
        {
            contactusPage.EnterEmailAddress(useremail);
        }

        [When(@"a user enter the subject ""(.*)""")]
        public void WhenAUserEnterTheSubject(string usersubject)
        {
            contactusPage.EnterSubject(usersubject);
        }

        [When(@"a user enter the message ""(.*)""")]
        public void WhenAUserEnterTheMessage(string usermessage)
        {
            contactusPage.EnterMessage(usermessage);
        }

        [When(@"a user click on submit")]
        public void WhenAUserClickOnSubmit()
        {
            contactusPage.ClickSubmit();
        }

        [Then(@"a successful message ""(.*)"" displayed")]
        public void ThenASuccessfulMessageDisplayed(string text)
        {
            contactusPage.SuccessfulMessageIsDisplayed(text);
        }

        [When(@"a user didn't enter subject")]
        public void WhenAUserDidnTEnterSubject()
        {
            contactusPage.EnterNoSubject();
        }

        [Then(@"error message ""(.*)"" displayed")]
        public void ThenErrorMessageDisplayed(string text)
        {
            contactusPage.ErrorMessageIsDisplayed(text);
        }


    }
}
