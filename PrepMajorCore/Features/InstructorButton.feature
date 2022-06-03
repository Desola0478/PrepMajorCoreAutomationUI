Feature: InstructorButton
	As a User on prepmajor website
I want to be able to click on the 'Become an  Instructor' button
So that I am navigated and have access to the Instructor's page


@Smoke
Scenario: Instructor Button
	Given a User navigates to "https://qa.prepmajor.com/"
	When user click on Become an Instructor
	Then become an instructor form is displayed