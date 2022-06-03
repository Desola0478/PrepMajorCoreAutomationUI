Feature: Registration
	As a new user of the PrepMajor
	I would like to Register
	So that i can use the site

@Smoke
Scenario: Valid Registration
	Given a user navigate to "https://qa.prepmajor.com/"
	And a user click on sign up
	When a user enter username "tester 3bbcd"
	And a user enter email "tester3acd@giftrete.com"
	And a user enter Password "Giftrete!321@#"
	And a user confirm password "Giftrete!321@#"
	And a user tick the checkbox to agree to the terms use and privacy policy
	And a user click on register
	Then user is logged into prepmajor site


@Smoke
Scenario: Invalid Registration
	Given a user navigate to "https://qa.prepmajor.com/"
	And a user click on sign up
	When a user enter username "tester 3bbcd"
	And a user enter wrong email "tester3a@giftretecom"
	And a user enter Password "Giftrete!321@#"
	And a user confirm password "Giftrete!321@#"
	And a user tick the checkbox to agree to the terms use and privacy policy
	And a user click on register
	Then an error message "Please enter valid E-mail field" is displayed