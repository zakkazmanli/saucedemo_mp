# Mini Automated Web Testing Project 

## Summary 

For this project, the site that you will be testing is https://www.saucedemo.com/. This has been created specifically for practicing automation coding. Your TASK is to look at the functionality for the website, derive user stories from this and create some test cases for said user stories. You can have as many Sprints as you require. 

## Project Goal
The goal of this project was to create a testing framework to support the automation testing of https://www.saucedemo.com/. This website was specifically created for the purposes of automation testing and as such supports multiple utilities of widely used websites, such as sign-in functionality and the ability to add items to a cart to be later checked out. This framework was to be created adhering to the POM design approach for automation testing, with the following tools used:

 - Selenium to enable simulations interactions with browser elements
 - SpecFlow to enable feature files to be written that mapped to user stories on our project board
 - Gherkin as a means of writing concise and readable acceptance criteria for user stories to represent user journeys on the website, which could then be mapped to test cases


## Project Definition of Done

- [ ] All user stories are marked as completed and tested.
- [ ] All unit tests pass.
- [ ] The end product is pushed to GitHub by TBC on 12/02/2021
- [ ] The documentation is fully realised, with a comprehensive README.md describing sprint progress and outcomes.
- [ ] The end product is reviewed and approved.



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


