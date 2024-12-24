@Sprint1
Feature: Login to OrangeHRM
 
Test orange hrm website login functionality
 Background: 
 	Given User is on the orange hrm login page

 @Sanity
Scenario Outline: Verify login for orange hrm website
	When User enters the "<usrname>" and "<passwd>" in the text fields
	When User clicks on submit button
	Then User is navigated to home page
 
	Examples: 
	| usrname | passwd   |
	| Admin   | admin123 |

@Regression
	Scenario Outline: Verify login for orange hrm website for invalid credentials
	When User enters the "<usrname>" and "<passwd>" in the text fields
	When User clicks on submit button
	Then User is on the home page and a error is displayed
 
	Examples: 
	| usrname | passwd   |
	| Admin1  | admin123 |

@Regression
	Scenario: Verify logo
	Then Logo is displayed successfully
 
 @Regression
 Scenario: Verify Forgot Password
	When User clicks on forgot password link
	Then User is navigated to Change Password url

@Sanity
Scenario Outline: Verify login with test parameters
	When User enters the "<username>" and "<password>"
	And User clicks on Login Button
	Then User is naviagted to home page
	Then User selects city and country information
	| city   | country |
	| Delhi  | India   |
	| Boston | USA     |

Examples: 
	| username | password   |
	| Admin   | admin123   |