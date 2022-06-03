using PrepMajorCore.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace PrepMajorCore.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()

        {
            registrationPage = new RegistrationPage();
        }

        [Given(@"a user navigate to ""(.*)""")]
        public void GivenAUserNavigateTo(string url)
        {
            registrationPage.Navigate(url);
        }

        [Given(@"a user click on sign up")]
        public void GivenAUserClickOnSignUp()
        {
            registrationPage.ClickSignUpField();
        }

        [When(@"a user enter username ""(.*)""")]
        public void WhenAUserEnterUsername(string name)
        {
            registrationPage.EnterUserName(name);
        }

        [When(@"a user enter email ""(.*)""")]
        public void WhenAUserEnterEmail(string email)
        {
            registrationPage.EnterEmail(email);
        }


        [When(@"a user enter Password ""(.*)""")]
        public void WhenAUserEnterPassword(string username)
        {
            registrationPage.EnterPassword(username);
        }

        [When(@"a user confirm password ""(.*)""")]
        public void WhenAUserConfirmPassword(string confirmuserpassword)
        {
            registrationPage.EnterConfirmPassword(confirmuserpassword);
        }

        [When(@"a user tick the checkbox to agree to the terms use and privacy policy")]
        public void WhenAUserTickTheCheckboxToAgreeToTheTermsUseAndPrivacyPolicy()
        {
            registrationPage.TickPrivacyPolicyCheckBox();
        }

        [When(@"a user click on register")]
        public void WhenAUserClickOnRegister()
        {
            registrationPage.ClickRegister();
        }

        [Then(@"user is logged into prepmajor site")]
        public void ThenUserIsLoggedIntoPrepmajorSite()
        {
            registrationPage.PrepMajorLogoIsDisplayed();
        }


        [When(@"a user enter wrong email ""(.*)""")]
        public void WhenAUserEnterWrongEmail(string wrongemail)
        {
            registrationPage.EnterWrongEmail(wrongemail);
        }

        [Then(@"an error message ""(.*)"" is displayed")]
        public void ThenAnErrorMessageIsDisplayed(string text)
        {
            registrationPage.ErrorMessageIsDisplayed(text);
        }

    }
}
