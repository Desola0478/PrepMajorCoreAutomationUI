using PrepMajorCore.PageObjects;
using PrepMajorCore.Utilities;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace PrepMajorCore.StepDefinitions
{
    [Binding]
    public class BecomeAnInstructorFormSteps
    {
        BecomeAnInstructorPO instructorForm;

        public BecomeAnInstructorFormSteps()
        {
            instructorForm = new BecomeAnInstructorPO();
        }

        [When(@"a user clicks become an instructor")]
        public void WhenAUserClicksBecomeAnInstructor()
        {
            instructorForm.ClickBecomeInstuctor();
        }

        [When(@"a user enter their details")]
        public void WhenAUserEnterTheirDetails(Table table)
        {
            var instructorDetails = table.CreateInstance<Details>();
            string degree = instructorDetails.Degree;
            string expertise = instructorDetails.Expertise;
            

            instructorForm.EnterDetails(degree, expertise);
        }

        [When(@"a user clicks on send application")]
        public void WhenAUserClicksOnSendApplication()
        {
           instructorForm.ClickSendApplication();
        }


        [Then(@"the filled form should be submitted '(.*)'")]
        public void ThenTheFilledFormShouldBeSubmitted(string message)
        {
            instructorForm.SuccessMessage(message);
        }

        [Then(@"the filled form should  not be submitted '(.*)'")]
        public void ThenTheFilledFormShouldNotBeSubmitted(string errMessage)
        {
            instructorForm.ErrorMessage(errMessage);
        }


        [When(@"a user clicks on the user icon on the side panel menu")]
        public void WhenAUserClicksOnTheUserIconOnTheSidePanelMenu()
        {
            instructorForm.UserIcon();
        }


        [Then(@"a user should be able to view the profile page")]
        public void ThenAUserShouldBeAbleToViewTheProfilePage()
        {
            instructorForm.ProfilePage();
        }


    }
}
