# Mini Automated Web Testing Project 

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

## Framework

The framework was designed using the POM (page object model) to represent individual website pages as objects, such that object oriented principles could be exploited in the testing of the website. This is illustrated in the class diagram below, where the website as a whole is first represented by the SD_Website class with each individual page instantiated by this class:

![](https://github.com/zakkazmanli/saucedemo_mp/blob/dev/SauceDemo_MP/ClassDiagram.png)

Through dependency injection, each page class is injected with the IWebDriver interface, with this interface being the means by which user interactions with the website are simulated through interacting with elements.

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

## Sprint Review

## Sprint Retrospective

This project was incredibly beneficial with regards to encouraging familiarity with building an automation testing framework, solidfying knowledge of the POM in the process and its benefits in creating a scalable framework. We additionally gained alot of experience with SpecFlow and Gherkin, appreciating the benefits in writing readable and concise user stories and acceptance criteria.

The project was not without any difficulty however - the key issue we encountered related to the sharing of step methods between feature files. SpecFlow is unfortunately unable to differentiate exactly which scenario is being called at any one time whenever a shared step method is called, and consequently multiple step page instances are created which in turn increases the time taken for tests to pass considerably. In the future, we would attempt to implement a shared steps class to hold these shared methods to ideally prevent this from happening. Additionally, we frequently had issues identifying web elements although this is more due to poor website design and web element identification, and actually serves to cause us to appreciate the benefits of appropriately assigning web elements unique identification when developing a website, for the benefit of those required to subsequently test the website.
