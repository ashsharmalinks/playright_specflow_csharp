Feature: EEApp login2
	
Scenario: login functionality for EEApp page2
	Given I have navigated to EEApp website
	And I click on the login link
	When I enter following login details
	| UserName | Password |
	| admin    | password |
	Then I see the employee details
	