#My Observations

The code has a very simplistic architecture. It has essentially separated all features and actions from one another thus giving way to a loosely coupled code.  
I think we could minimize the duplication of Command, ViewModels and CommandBuilders by just using one ViewModel and building them inside their own classes.

My thoughts on scaling and making the app more responsive - 
1. We could make use of asynchronous request response architecture that allows applications to be more reactive and responsive. 
2. We could create an API project that serves as a one stop shop for all access to database and its services, this makes the application and codebase more secure and also allows all applications to use the same set of RESTful APIs.
3. We could make use of AutoMapper that easily transforms the data models to its respective DTOs, thus securing data even further by one level.
4. The View Models are good in that they are closely placed by their respective controllers.
5. We could add more levels of security by creating an Identity Server that performs the tasks of Authenticating incoming user requests from all applications in the organization.
6. We could also give a response based model in the application where the user is notified of the result of the action he performed, which in the current case is not implemented.

7. BuyerId was missing in the Offers table, so I have added it there.
8. Viewing requests has been added as a new feature in the application.
9. Entity Framework project could be a separate project dedicated to take care of the persistence across all projects.
10. Unit testing can also be worked on, to allow complete testability.


# Purplebricks Developer Test

The aim of this test is to give us an idea about how you approach the development and maintenance of web applications. You will work from a GitHub repository which contains an existing web application. The UI should be functional, but there is no expectation that you modify the brand theme. We are looking for a solution that shows how you build maintainable, scalable and secure software. The test is based on an overly simplified version of our business domain.

The existing web application supports two types of customer. Sellers are able to upload information about a property and list the property for sale. Buyers can search for a property and make an offer. When an offer has been placed on a property the seller should be able to accept or reject the offer.

## Test Objectives

### Objective 1 - Extend an existing feature

We need you to extend the offer functionality of the web application so that when a seller accepts an offer the buyer that placed the offer can see that their offer has been accepted.

**User Story:** *As a buyer I want to see when my offer has been accepted so that I can proceed with the property purchase.*

### Objective 2 – Add a new feature

We need you to add the ability for a buyer to book a viewing. It’s unlikely a customer would want to make an offer on a property without booking a viewing.

**User Story:** *As a buyer I want to book a viewing appointment at a property so that I can determine whether I would like to make an offer.*

### Objective 3 - Review the existing code

Write a short review of the existing sample codebase. Let us know what you think is good or bad about it. Feel free to fix any problems and commit these changes to the solution.

#### Deliverables

Your submission should be delivered in as a Visual Studio solution compatible with Visual Studio 2015. The solution should compile. For data persistence please use the existing Entity Framework model with SQL. Feel free to add migrations if you need to. 
We would prefer that the solution is delivered via GitHub. If you are not able to fork this original repository publically then please fork to a private repository and then provide us with the zip file from the download option in GitHub.

Good luck!

## FAQs

* Should I show my commit history?
    * Showing your commit history is recommended so that we can see your approach.

* How long should I spend working on the assignment?
    * You can take as long as you need to complete the assignment. But do remember that this is throwaway code and the aim is to demonstrate your approach rather than build a complete system.

* Do I need to deploy the application?
    * If you wish to demonstrate your working app then you may deploy it to Azure on a free trial account. This is not mandatory.
