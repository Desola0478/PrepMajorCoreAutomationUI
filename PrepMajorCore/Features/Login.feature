Feature: Login
	As a registered user of PrepMajor.com
	I would like to log in
	So that I can use the site


	Background:
	Given a user navigate to "https://qa.prepmajor.com/"
	And a user  click on log in field 
	

@Smoke
Scenario: Valid Login
	
	When a user enter Username "tester 3bb"
	And a user enter password "Giftrete!321@#"
	#And a user tick remember me field
	And a user click on login button
	Then a user should be logged into the site

@Smoke
Scenario Outline: User Valid Login with Examples
	When a user enter Username "<username>" 
	And a user enter password "<password>"
	Then a user should be logged into the site

Examples: 
	| Username        | Password	   |
	|tester 3bb       |Giftrete!321@#  |

@Regression
Scenario Outline:User Login with invalid username
	When a user enter Username "<username>"
	And a user enter password "<password>"
	And a user click on login button
	Then user should be not logged into the site
	
	
Examples: 
	| Username   | Password       |
	| tester 3b  | Giftrete!321@# |
	| tester 3bb | test23         |