Feature: AutomationPractice
	Simple calculator for adding two numbers

@Assignment
Scenario: Order tshirt and verify order history
	Given I login to Automation Practice website
	When  I navigate to 'Tshirt' Tab
	And   I add a product to cart
	And   I complete Summary stage
	And   I complete Address stage
	And   I complete Shipping stage
	And   I complete Payment stage by select payment option as 'Bank'
	And   I confirm my order
	And   I get my order reference number
	Then  I verify order in Order History

@Assignment
Scenario: Update First Name and Verify
	Given I login to Automation Practice website
	When  I navigate to personal information page
	And   I update First Name
	And   I enter password
	And   I save the details
	Then  I verify the updated First Name