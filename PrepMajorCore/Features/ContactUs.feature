Feature: ContactUs
	As a new user of PrepMajor website
	I can't register with their website
	I need to report the issue, so that it cant be fix

@mytag
Scenario: Contact Us
	Given that a user navigate to "https://prepmajor.com/"
	When a user click contact us button
	And a user enter name "Tester 3"
	And a user enter email address "tester3@giftrete.com"
	And a user enter the subject "Sign Up"
	And a user enter the message "I am having issue signing up"
	And a user click on submit
	Then a successful message "Thank you for your message. It has been sent." displayed


Scenario: Contact Us with error message
	Given that a user navigate to "https://prepmajor.com/"
	When a user click contact us button
	And a user enter name "Tester 3"
	And a user enter email address "tester3@giftrete.com"
	And a user didn't enter subject 
	And a user enter the message "I am having issue signing up"
	And a user click on submit
	Then error message "One or more fields have an error. Please check and try again." displayed