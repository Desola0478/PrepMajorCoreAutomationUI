Feature: InstructorsPanelView
   As an instructor 
   I want to have a view of options on my profile page 
   So that I can navigate easily

@Smoke
Scenario: InstructorsPanelView 
	Given a user navigate to "https://qa.prepmajor.com/" 
	And a user  click on log in field 
	When a user enter Username "tester 3bb"
	And a user enter password "Giftrete!321@#"
	And a user click on login button
	Then user is able to see on the left side a navigation panel