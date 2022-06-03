Feature: HeaderViewDesign
   As a user on www.courses.prepmajor.com 
   I want to see the main menu and key navigational elements
   So that I am able to explore and interact with the website effectively

@Smoke
Scenario: HeaderViewDesign
	Given a user navigate to "https://qa.prepmajor.com/"
	Then user is able to view the main header menu
	