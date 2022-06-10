# Project: Robot Invasion!

Robots have escaped the secret government robot lab and are attacking pedestrians on site!
Albanese has called your boss (head of the IT security team) to put together a solution.
The robots have dispersed across the nation overnight and need to be dealt with!
Luckily, they are allergic to h2O and can be disabled by submerging in water.
Your boss has decided we need a web API where anyone inside Australia can signal the location of an identified robot.
In reponse to this request, your application needs to send the location of the nearest water source.

## Due date:

10/06/22 11:59pm

## Objective

- The purpose of this project is to give you hands on experience using ASP.NET Core Web API
- The following features will be focused on:
  - [Services](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-6.0)
  - [Logging](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/logging/?view=aspnetcore-6.0)
  - [Configuration](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-6.0)
  - [Dependency Injection](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/dependency-injection?view=aspnetcore-6.0)

## MVP

Create an ASP.NET Core Web API which serves a nearby water source location given location data:

- Create a controller which handles the /RobotSpotted endpoint.
- Create a model for the POST data you expect to receive through the /RobotSpotted endpoint.
- Create a service which consumes the https://nominatim.openstreetmap.org/ API

## Bonuses

- Include at least 2 different endpoint types for different types of robot emergencies.
- Reject any spoof requests created by robots... (requests that originate from outside Australia) they are onto us!
- Add unit tests and integration test projects.
- Add a database layer using Entity Framework to store requests.

## Tips

- Write out your highest level logic first, and then fill out the implimentation afterwards.
- Focus on the control flow of data in your API. Where does the data enter the app? Where does it exit?
- Third party API docs https://nominatim.org/release-docs/develop/api/Search/
- Third party API example endpoint https://nominatim.openstreetmap.org/reverse?format=json&lat=-32&lon=151.2082848
