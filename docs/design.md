# Design

## Projects

The automation will be separated into these projects:

+ PowerShellLive.Functions - Contains the Azure Functions
+ PowerShellLive.Common - Contains the Business logic. This will allow the code to be used in more than azure functions and make the project easier to test.
+ PowerShellLive.Twitter - Contains the Twitter Client
+ PowerShellLive.Discord - Contains the Discord Client
+ PowerShellLive.Twitch - Contains the Twitch Client
+ PowerShellLive.Twitch.Models - Contains supplementary models not found in TwitchLib

## IPC

The previous design used queues to communicate between functions.
This often resulted in some painful behavior.
For the most part, our processes execute in the time allowed by Azure Functions making it ok to run all related tasks in a single function.
The possible pain point for this would be webhook subscription management.
If we ever had a large number of users, it may take too long to register them all.
in that case, we would need to break the function for that up into queue fed functions.

## Final Deprecation of Event Notifications

Twitch deprecated events and has since removed the feature form its platform.
This means we will not port the Event notification code to this project.

## Models and Interfaces in Separate Libraries

Models and interfaces should remain in separate libraries.
While this does complicate project maintenance, it is extremely useful for code reuse in other projects.
For example, the TwitchLib project has done some awesome work creating models that reflect the Twitch API.
However, those models are coupled in libraries containing business logic we don't need.

## Favor Interface Parameters over Concrete Types

While there may only ever be a 1:1 mapping between an interface and a concrete implementation, methods and constructor's should favor interfaces for parameters.

## Test, Tests, and More Tests

The previous project had no tests.
This project should seek to maintain a high percent of code coverage for libraries with business logic.
This is another reason interfaces and models and interfaces should be separate libraries as they contain no business logic and thus require no tests.
