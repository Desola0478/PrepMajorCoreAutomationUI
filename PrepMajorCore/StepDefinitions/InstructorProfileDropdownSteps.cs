using System;
using TechTalk.SpecFlow;

namespace PrepMajorCore.StepDefinitions
{
    [Binding]
    public class InstructorProfileDropdownSteps
    {
        [Given(@"that I am an instructor on ""(.*)""")]
        public void GivenThatIAmAnInstructorOn(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I log into my account")]
        public void WhenILogIntoMyAccount()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on my user Id on the header")]
        public void WhenIClickOnMyUserIdOnTheHeader()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"""(.*)"" as part of the drop-down options is displayed")]
        public void ThenAsPartOfTheDrop_DownOptionsIsDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
