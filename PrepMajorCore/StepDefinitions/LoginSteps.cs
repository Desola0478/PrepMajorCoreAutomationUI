using PrepMajorCore.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace PrepMajorCore.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {

        LoginPage loginPage;

        public LoginSteps()

        {
            loginPage = new LoginPage();
        }

        [Given(@"a user  click on log in field")]
        public void GivenAUserClickOnLogInField()
        {
            loginPage.ClickLoginField();
        }

        [When(@"a user enter Username ""(.*)""")]
        public void WhenAUserEnterUsername(string name)
        {
            loginPage.EnterUserName(name);
        }

        [When(@"a user enter password ""(.*)""")]
        public void WhenAUserEnterPassword(string userpassword)
        {
            loginPage.EnterPassword(userpassword);
        }


        [When(@"a user tick remember me field")]
        public void WhenAUserTickRememberMeField()
        {
            loginPage.TickRememberMe();
        }

        [When(@"a user click on login button")]
        public void WhenAUserClickOnLoginButton()
        {
            loginPage.ClickLoginButton();
        }


        [Then(@"a user should be logged into the site")]
        public void ThenAUserShouldBeLoggedIntoTheSite()
        {
            loginPage.ForEnterpriseIsDisplayed();
        }


        [Then(@"user should be not logged into the site")]
        public void ThenUserShouldBeNotLoggedIntoTheSite()
        {
            loginPage.ErrorMessageIsDisplayed();
        }
    }
}
