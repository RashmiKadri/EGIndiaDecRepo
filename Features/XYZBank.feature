Feature: XYZBank

XYZ bank login

 Background: 
 	Given Load the XYZ bank url

@Regression
Scenario: Verify Landing page 
	When XYX Bank is displayed

@Regression
Scenario: Verify clicking on Customer Login 
	When Click on Customer Login button
	Then Your Name is displayed
	When User clicks on the Dropdown
	Then User LOgin
	And Screen with User with Transactions, Deposits and Withdrawals are displated
	Then Click on Log OUt
	And User is successfully logged out
	

@Regression
Scenario:Verify clicking on Bank Manager Login 
	When Click on Bank Manager Login button
	Then Three tabs with Add Customer, Open Account and Customers are displayed