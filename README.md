# Mini Automated Web Testing Project 

## Summary 

For this project, the site that you will be testing is https://www.saucedemo.com/. This has been created specifically for practicing automation coding. Your TASK is to look at the functionality for the website, derive user stories from this and create some test cases for said user stories. You can have as many Sprints as you require. 

## Test Cases
#### 1. Sign in Page 
- Invalid username 
- Invalid password
- Valid user
- Locked out user
- problem? user
- Performance issue? user
- No username
- No password
- No details

#### 2. Products Page
- Adding item to cart
- Removing item from cart
- Filtering products
- Going to cart
- Adding an item and going into item description

#### 3. Cart Page
 - Checkout Item(s)
 - Remove Item
 - Continue Shopping
 - View Item

#### 4. Checkout One Page
 - All Fields Empty
 - First Name Empty
 - Last Name Empty
 - Postcode Empty
 - Return to Cart 
 - Second Checkout Page

#### 5. Checkout Two Page
 - Return to Products 
 - Send Order 
 - View Item
 - Correct Item Total

#### 6. Product Page
- Add to cart
- Remove
- Back


## Framework
* Controller Class to control all the POMs (Page Object Models) which includes a constructor which instantiate the driver and instantiates the page object with the selenium driver 
* Each POM will have its own feature file which will include the tests for that POM
* Writing the test in a Specflow feature file in Gherkin syntax so it is human readable and clear what each test checks
* Then creating step definitions to match each statement in the feature file 
* Step definition classes then call methods from a class which holds methods for the POM in test  




 
## Deliverables 

Up to date project board  

High quality user stories and test cases 

Fully functional test framework using POM pattern 

Very clear Gherkin scenarios that represent the user journeys 

A README.md that includes all your documentation of what you have tested and how to run your test framework. 

Use GitHub collaboratively 

Present your work on Friday 9th Feb (Time TBC) 
