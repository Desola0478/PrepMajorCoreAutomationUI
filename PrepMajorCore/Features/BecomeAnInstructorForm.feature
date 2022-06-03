Feature: BecomeAnInstructorForm
	Given I am a user on courses.premajor.com 
	I want to be able to fill and submit an instructors form
	so that I can become an instructor


@Smoke
Scenario: Instructor Form
	Given a user navigate to "https://qa.prepmajor.com/"
	And a user  click on log in field 
	When a user enter Username "Gloria"
	And a user enter password "Giftrete!321@#"
	And a user click on login button
	And a user clicks become an instructor
	And a user enter their details
	| Field      | Value                  |
	| Degree     | M.Sc                   |
	| Expertise  | Quality Assurance      |
	And a user clicks on send application
	Then the filled form should be submitted 'Your application is approved please click outside the box'

@Smoke
Scenario: Invalid Instructor Form
	Given a user navigate to "https://qa.prepmajor.com/"
	And a user  click on log in field 
	When a user enter Username "Gloria"
	And a user enter password "Giftrete!321@#"
	And a user click on login button
	And a user clicks become an instructor	
	And a user enter their details
	| Field      | Value                  |
	| Degree     |		                  |
	| Expertise  | Quality Assurance      |
	And a user clicks on send application
	Then the filled form should  not be submitted 'Please fill all fields'

@Smoke
Scenario: Profile Page
	Given a user navigate to "https://qa.prepmajor.com/"
	And a user  click on log in field 
	When a user enter Username "tester3@giftrete.com"
	And a user enter password "Giftrete!321@#"
	And a user click on login button
	And a user clicks on the user icon on the side panel menu
	Then a user should be able to view the profile page
