Feature: SD_Signin
	In order to be able to buy items
	As a registered user of the sauce demo website
	I want to be able to sign in to my account

@SuccessfulLogin
Scenario: Successful Login
	Given I am on the sign in page
	When I enter a username <usernames> and password "secret_sauce"
	And I click the login button
	Then I should be redirected to the products page
	Examples:
		| usernames               |
		| standard_user           |
		| problem_user            |
		| performance_glitch_user |