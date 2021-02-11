Feature: CheckoutPageFeature
		 As a registered user
		 In order to buy an item
		 I need to enter my details and checkout


@checkouterror
Scenario: Checkout Page : All Fields Empty
Given I have signed in as "standard_user" with the password "secret_sauce"
And I am on the checkout page 
When I press "Continue"
Then I should receive the error containing "First Name is required"

@checkouterror
Scenario: Checkout Page, First Name Empty
Given I have signed in as "standard_user" with the password "secret_sauce"
And I am on the checkout page 
When I enter a "lastname" and "postcode"
And I press "Continue"
Then I should receive the error containing "First Name is required"

@checkouterror
Scenario: Checkout Page, Last Name Empty
Given I have signed in as "standard_user" with the password "secret_sauce"
And I am on the checkout page 
When I enter a "firstname" and "postcode"
And I press "Continue"
Then I should receive the error containing "Last Name is required"

@checkouterror
Scenario: Checkout Page, Postcode Empty
Given I have signed in as "standard_user" with the password "secret_sauce"
And I am on the checkout page 
When I enter a "firstname" and "lastname"
And I press "Continue"
Then I should receive the error containing "Postal Code is required"

@checkoutreturn
Scenario: Checkout Page, Return to Cart
Given I have signed in as "standard_user" with the password "secret_sauce"
And I am on the checkout page 
When I press "Cancel"
Then I land on the Cart Page 

@checkoutcontinue
Scenario: Checkout Page, To Second Checkout Page
Given I have signed in as "standard_user" with the password "secret_sauce"
And I am on the checkout page 
When I fill in the firstname, secondname, postcode
And I press "Continue"
Then I land on the Second Checkout Page