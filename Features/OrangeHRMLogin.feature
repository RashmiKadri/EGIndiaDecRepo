@Sprint2
Feature: Test OrangeHRMLogin

A short summary of the feature

@tag1
Scenario: : Verify Login functionality with valid credentials
	Given User is on Login Page
	When  User enters the Username and Password
	And User clicks on Login Button
	Then User is navigated to HomePage

	