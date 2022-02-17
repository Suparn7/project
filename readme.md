## Backend Assignment: 
Simple Todos on Board API The assignment involves the creation of a Todo on different boards via REST JSON API using ASP.NET Core. Please use the following libraries and versions:
   - ASP.NET Core 5.0+

## Todos on Board API: 
We want to create RESTful APIs for a simple Todo management application. The APIs will perform CRUD operation for Todos and Boards. Todos are organized in boards, on every board there can be multiple Todos. A Todo contains a title (str), done (bool), a created (datetime) and updated (datetime) timestamp. A board has a name (str).

Via a REST API it must be possible to:
<!-- - List all boards -->
https://localhost:5001/api/board


<!-- - Add a new board  -->
https://localhost:5001/api/board


<!-- - Change a board's title  -->
https://localhost:5001/api/board/1


<!-- - Remove a board  -->
https://localhost:5001/api/board/1


<!-- - List all Todos on a board  -->
https://localhost:5001/api/todoitems/1


<!-- - List only uncompleted Todos  -->
https://localhost:5001/api/todoitems/uncompletedTodos


<!-- - Add a Todo to a board  -->
https://localhost:5001/api/todoitems

- Change a Todo's title or status 
<!-- https://localhost:5001/api/todoitems/7 -->

<!-- - Delete a Todo  -->
https://localhost:5001/api/todoitems/3

-user management

-jwt

User management and authentication is a plus. The data have to be persisted in SQL Server using EF Core.

## How to work on the assessment:
Clone this repository - https://github.com/cybergroupdevs/todoonboard-api

Start working on the assignment

Please do periodic commits with meaningful commit messages

Once you are done push your final results

Please include a brief description how to run your solution

If you have any questions contact me (lagnesh.thakur@cygrp.com)

Please note that any solution without periodic commits or inexecutable code will not be considered.
