## Backend Assignment: 
Simple Todos on Board API The assignment involves the creation of a Todo on different boards via REST JSON API using ASP.NET Core. Please use the following libraries and versions:
   - ASP.NET Core 5.0+

## Todos on Board API: 
We want to create RESTful APIs for a simple Todo management application. The APIs will perform CRUD operation for Todos and Boards. Todos are organized in boards, on every board there can be multiple Todos. A Todo contains a title (str), done (bool), a created (datetime) and updated (datetime) timestamp. A board has a name (str).

<!-- Brief description to run the application: -->
Clone the project --> install required packages with version 5.0 --> run the project
Open postman -> Use Different http methods(Listed below) to access everything assigned in the task.


## SOLUTION

## Via a REST API it is possible to:

<!-- - List all boards -->[DONE]
https://localhost:5001/api/board 
<!-- GET -->


<!-- - Add a new board  -->[DONE]
https://localhost:5001/api/board
<!-- POST -->


<!-- - Change a board's title  -->{DONE}
https://localhost:5001/api/board/1
<!-- PATCH -->


<!-- - Remove a board  -->[DONE]
https://localhost:5001/api/board/1
<!-- DELETE -->


<!-- - List all Todos on a board  -->[DONE]
https://localhost:5001/api/todoitems/1
<!-- POST with board id and authorization token-->


<!-- - List only uncompleted Todos  -->[DONE]
https://localhost:5001/api/todoitems/uncompletedTodos
<!-- GET -->


<!-- - Add a Todo to a board  -->[DONE]
https://localhost:5001/api/todoitems
<!-- POST with board  id -->

<!-- - Change a Todo's title or status --> [DONE]
<!-- https://localhost:5001/api/todoitems/7 -->
<!-- PATCH send id -->

<!-- - Delete a Todo  -->[DONE]
https://localhost:5001/api/todoitems/3
<!-- DELETE with id -->

<!-- -user management -->[DONE]
https://localhost:5001/users/create
<!-- CREATE by passing firstname, lastname,username and password -->


<!-- -user autthentication -->  [DONE]
https://localhost:7186/Users/authenticate
<!-- POST by passing username and password saved in database -->

Data is being persisted in SQL Server using EF Core.

## How to work on the assessment:
Clone this repository - https://github.com/cybergroupdevs/todoonboard-api



If you have any questions contact me (suparn.kumar@cygrp.com)


