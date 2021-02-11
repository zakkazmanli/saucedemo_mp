﻿Feature: SD_Signin
	In order to be able to buy items
	As a registered user of the sauce demo website
	I want to be able to sign in to my account

@SuccessfulLogin
Scenario: Successful Login
	Given I am on the sign in page
	When I enter a username <usernames> and password <passwords>
	And I click the login button
	Then I should be redirected to the products page
	Examples:
		| usernames               | passwords    |
		| standard_user           | secret_sauce |
		| problem_user            | secret_sauce |
		| performance_glitch_user | secret_sauce |

@UnsuccessfulLogin
Scenario: Locked out user
	Given I am on the sign in page
	When I enter a username "locked_out_user" and password "secret_sauce"
	And I click the login button
	Then I should receive an error containing "Sorry, this user has been locked out."


@UnsuccessfulLogin
Scenario: Invalid username
	Given I am on the sign in page
	When I enter an invalid username of "test_user" and password "secret_sauce"
	And I click the login button
	Then I should receive an error containing "Username and password do not match any user in this service"

@UnsuccessfulLogin
Scenario: No username or password
	Given I am on the sign in page
	When I enter no username or password
	And I click the login button
	Then I should receive an error containing "Username is required"

@UnsuccessfulLogin
Scenario: No username
	Given I am on the sign in page
	When I enter a username  and password "secret_sauce"
	And I click the login button
	Then I should receive an error containing "Username is required"

@UnsuccessfulLogin
Scenario: No password
	Given I am on the sign in page
	When I enter a username "standard_user" and password ""
	And I click the login button
	Then I should receive an error containing "Password is required"

@ClickingErrorButton
Scenario: Clicking error button
	Given I am on the sign in page
	When I enter a username <usernames2> and password <passwords2>
	And I click the login button
	And I click the remove error message button
	Then there should be no visible error message
		Examples:
		| usernames2               | passwords2   |
		| locked_out_user          | secret_sauce |
		|                          | secret_sauce |
		| performance_glitch_user  |              |

