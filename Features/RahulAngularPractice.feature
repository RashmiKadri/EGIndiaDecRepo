@Sprint3
Feature: RahulAngularPractice


@tag1
Scenario: Verify entering the data in all the fields
	Given Load the practice url
	When User enters the data in Name, Password, Email Field
	| Name   | Password | Email                  |
	| Rashmi | Kadri    | rashmi.kadri@gmail.com |
	Then Data entered in Name, Password and Email field
	And User selects gender and status
	Then User enters DOB
	
