Feature: CookiesBanner
	As a new user of PrepMajor website
	I will like to accept the cookie
	So that I can use the website

@mytag
Scenario: Accept All Cookies
	Given that a user navigate to "https://prepmajor.com/"
	When a user click on accept all cookies
	Then user can effectively use the website

Scenario: Manage Cookies
	Given that a user navigate to "https://prepmajor.com/"
	When a user click on manage cookies
	And a user enable functional cookies
	And a user enable analytics cookies
	And a user click on save & accept
	Then user can see about us on the website
