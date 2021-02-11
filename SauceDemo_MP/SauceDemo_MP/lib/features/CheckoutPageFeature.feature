Feature: CheckoutPageFeature
		 As a registered user
		 In order to buy an item
		 I need to enter my details and checkout



@checkout
Scenario:Checkout Page : All Fields Empty
Given I am on the checkout page 
When I press "Continue"
Then I get an error saying "First Name is required"