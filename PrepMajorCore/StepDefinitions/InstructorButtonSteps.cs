using NUnit.Framework;
using OpenQA.Selenium;
using PrepMajorCore.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace PrepMajorCore.StepDefinitions
{
    [Binding]
    public class InstructorButtonSteps
    {

        public IWebDriver driver;
        InstructorButtonPage instructorButtonPage = new InstructorButtonPage();


        [Given(@"a User navigates to ""(.*)""")]
        public void GivenAUserNavigatesTo(string url)
        {
           instructorButtonPage.Navigate(url);
        }
       
        [When(@"user click on Become an Instructor")]
        public void WhenUserClickOnBecomeAnInstructor()
        {
            instructorButtonPage.InstructorButton();
        }
        
        [Then(@"become an instructor form is displayed")]
        public void ThenBecomeAnInstructorFormIsDisplayed()
        {
            Assert.IsFalse(instructorButtonPage.IsFormDisplayed());
        }
    }
}
