# RPLSPAPI

hi :) 

This is implemented solution for RPSLS API. Implemented methods are following:

- /choices
- /choice
- /play 

and two methods for scoreboard

- /scoreboard/latest
- /socreboard/reset

Regarding testing, I have used ngrok to attain public URL for API, in order to test with page https://codechallenge.boohma.com/ 

For testing API locally, I have used Swagger and Postman (there  is postman collection used for testing in solution in project RockPaperScissorsSpockLizard, it can be imported into postman and used, API url is set in collection as variable)

Also, I have added unit tests for certain casses.

 API during testing has been run with IIS Express settings in VS2022.  There is alo a Docker file, but it is not tested, I had issues with Docker Desktop, so IIS Express configuration should be used.

MediatR library is used for implementing commands and querie. 
