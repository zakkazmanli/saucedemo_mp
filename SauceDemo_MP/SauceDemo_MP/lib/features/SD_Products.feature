Feature: SD_Products
	In order to be able to buy items
	As a registered user of the sauce demo website
	I want to be able to view and order products appropriately

@AddingItemToCart
Scenario: Adding item to cart
	Given I am on the products page
	When I click to add an item to cart
	Then the cart number increases by one
	And the add to cart button on the added item changes text to remove


@AddingItemToCart
Scenario: Adding an item and clicking on item description
	Given I am on the products page
	When I click to add an item to cart
	And I click to go to that item's page
	Then I am only able to remove that item from cart

@RemovingItemFromCart
Scenario: Removing an item from cart
	Given I am on the products page
	When I click to remove an item from cart
	Then the cart number size decreases by one
	And the add to cart button on the added item changes text to remove


@OrderingProducts
Scenario: Order products by price ascending
	Given I am on the products page
	When I select Price (low to high)
	Then the products are ordered in ascending price order

@OrderingProducts
Scenario: Order products by price descending
	Given I am on the products page
	When I select Price (high to low)
	Then the products are ordered in descending price order

#@OrderingProducts
#Scenario: Order products in alphabetical order
#	Given I am on the products page
#	When I select Price (high to low)
#	Then the products are ordered in alphabetical order
#
#@OrderingProducts
#Scenario: Order products in reverse alphabetical order
#	Given I am on the products page
#	When I select Price (high to low)
#	Then the products are ordered in reverse alphabetical order
#
#@NavigatingToCart
#Scenario: Navigating to cart
#	Given I am on the products page
#	When I press the cart icon
#	Then I am taken to the checkout page