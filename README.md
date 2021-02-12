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

![](https://github.com/zakkazmanli/saucedemo_mp/blob/dev/SauceDemo_MP/POMPicture.PNG)

Through dependency injection, each page class is injected with the IWebDriver interface, with this interface being the means by which user interactions with the website are simulated through interacting with elements. We could then write our SpecFlow features to correspond to each test case for a given user story using Gherkin syntax. An example of this for the signin page is shown below:

![](https://github.com/zakkazmanli/saucedemo_mp/blob/dev/SauceDemo_MP/FeatureBetter.PNG)

## Sprint Review

At the beginning of the sprint, we started by performing exploratory testing of the website to get a feel for what utilities were suppored, and importantly how error messages could be found. We subsequently wrote user stories to cover the possible journeys a user would take whilst using the website, and the Gherkin syntax was written to exhaust all possible routes within each user story. We divided the user stories equally between each team member, and at sprint completion all user stories had been completed, with tests corresponding to the test cases all passing and hence satisfying that criterion in the project definition of done.

## Sprint Retrospective

This project was incredibly beneficial with regards to encouraging familiarity with building an automation testing framework, solidfying knowledge of the POM in the process and its benefits in creating a scalable framework. We additionally gained alot of experience with SpecFlow and Gherkin, appreciating the benefits in writing readable and concise user stories and acceptance criteria.

The project was not without any difficulty however - the key issue we encountered related to the sharing of step methods between feature files. SpecFlow is unfortunately unable to differentiate exactly which scenario is being called at any one time whenever a shared step method is called, and consequently multiple step page instances are created which in turn increases the time taken for tests to pass considerably. In the future, we would attempt to implement a shared steps class to hold these shared methods to ideally prevent this from happening. Additionally, we frequently had issues identifying web elements although this is more due to poor website design and web element identification, and actually serves to cause us to appreciate the benefits of appropriately assigning web elements unique identification when developing a website, for the benefit of those required to subsequently test the website.
