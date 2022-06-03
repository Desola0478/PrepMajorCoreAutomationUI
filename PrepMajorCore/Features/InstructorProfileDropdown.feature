Feature: InstructorProfileDropdown
	  I want to click on my Id on the header of my page  
	  So that I can select my profile from the drop down to access it.  




@mytag
Scenario: My Profile dropdown
	Given that I am an instructor on "https://qa.prepmajor.com/"
	When I log into my account
	And I click on my user Id on the header
	Then "My Profile" as part of the drop-down options is displayed
	