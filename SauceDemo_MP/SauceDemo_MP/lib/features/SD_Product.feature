Feature: SD_Product
	Exploring the interactions with the
	individual product pages

@Product
Scenario: Add item to cart
	Given I have signed in as "standard_user" with the password "secret_sauce"
	And I click <product_name>
	And There are no items in my cart
	When I click the add to cart button
	Then the cart number size increases by one
	And the add to cart button changes to remove
	Examples:
		| product_name                      |
		| Sauce Labs Backpack               |
		| Sauce Labs Bolt T-Shirt           |
		| Sauce Labs Bike Light             |
		| Sauce Labs Fleece Jacket          |
		| Sauce Labs Onesie                 |
		| Test.allTheThings() T-Shirt (Red) |