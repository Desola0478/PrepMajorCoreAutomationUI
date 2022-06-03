Feature: CustomizedDomain
	As a new user of PrepMajor
	I want to request for the Customized Domain Price Plan

@mytag
Scenario: Customized Domain Price  Plan
	Given that a user navigate to "https://prepmajor.com/request-a-quote/"
	#When a user click pricing
	#And a user click on request a quote
	When a user enter first and last name "QA Tester"
	And a user enter company email address "tester3@giftrete.com"
	And a user enter company name "Giftrete"
	And a user enter phone number "07459788293"
	And a user enter country "United Kingdom"
	And a user select book a free demo "Yes"
	And a user select do you want to book a meeting now "Yes- Book a Meeting"
	And a user briefly describe his need "I want to know more about the plan"
	And a user click on submit button
	Then a successful message "Thank you for your message. It has been sent." displayed