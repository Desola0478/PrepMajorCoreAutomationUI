using PrepMajorCore.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace PrepMajorCore.StepDefinitions
{

    [Binding]
    public class HeaderViewDesignSteps
    {

        HeaderViewDesignPage headerViewDesignPage;

        public  HeaderViewDesignSteps()
        {
            headerViewDesignPage = new HeaderViewDesignPage();
        }

       [Then(@"user is able to view the main header menu")]
        public void ThenUserIsAbleToViewTheMainHeaderMenu()
        {
            headerViewDesignPage.SearchCoursesIsDisplayed();
            
        }

        [Then(@"user is able to view the header menu")]
        public void ThenUserIsAbleToViewTheHeaderMenu()
        {
            headerViewDesignPage.BlogIsDisplayed();
        }

    }
}
