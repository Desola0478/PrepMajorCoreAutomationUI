using PrepMajorCore.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace PrepMajorCore.StepDefinitions
{
    [Binding]
    public class InstructorsPanelViewSteps
    {
        InstructorPanelViewPage instructorPanelViewPage;

        public InstructorsPanelViewSteps()
        {
            instructorPanelViewPage = new InstructorPanelViewPage();
        }


        [Then(@"user is able to see on the left side a navigation panel")]
        public void ThenUserIsAbleToSeeOnTheLeftSideANavigationPanel()
        {
            instructorPanelViewPage.InstructorPictureIsDisplayed();
        }
    }
}
