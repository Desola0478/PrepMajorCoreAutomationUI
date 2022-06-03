Feature: ForgottenPassword
	As a registered Instructor on courses.prepmajor website who has forgotten their password
    I want to enter my username or email address
    So that I can receive an automated email to reset my password

@mytag
Scenario: Forgotten Password
	Given user navigate to www.courses.prepmajor.com
	When user click on Login
	And user enter  username/Email
	And user enter a wrong password
	And user clicks login
	And user clicks on forgotten password
	And user enters  valid email address or username  into the empty field
	And User clicks on send button
	Then user receive an automated email to their registered email address
	And User enters new password 
	And User clicks on submit
	Then user is directed to prepmajor website
