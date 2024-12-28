

# livrariaaberta.pt

  ### <ins>**About**</ins>
  \
The Aberta project is a three part software that offers features for a bookshop
to manage stock, display books and gather detailed data from the books.

This software is composed by

**API**\
The API allows users to use CRUD features from a REST API that returns detailed
data of each book, tag, images, etc...

**BackOffice**\
BackOffice allows users to manage books and images and list all books and search
by keywords.
The BackOffice website is protected with authentication and 2fa.

**Scanner**\
The Scanner is a piece of software that analysis the database and gathers
information from library APIs and updates the books. This software also runs
scheduled jobs to update stock from the VendusAPI.

![Image](https://github.com/VilMano/livrariaaberta.pt/blob/main/Untitled%20Diagram.jpg?raw=true)

### <ins>**Prerequisites**</ins>
To run this project in its fullest, you must install a few things.
 * Docker
 * .NET sdk 8.0 tools
 * git



### <ins>**Running**</ins>

First of all, clone the project

    $ git clone git@github.com:VilMano/livrariaaberta.pt.git
    $ cd livrariaaberta.pt

Now you are presented with three folders (BackOffice, API, Scanner). 
Let's start by running the API project which contains the database and API.

Warning: Edit the appsettings.cs file before running the container.

    $ cd API
    $ docker compose up -d

That should be all for the project to be up, just open your browser and check the API endpoint (Swagger):

    http://localhost:{port}/swagger/index.html


\
The process will be the same for the Scanner and BackOffice projects.
Hangfire (Scanner project) can be found at http://localhost:{port}/hangfire and the BackOffice can be reached at http://localhost:{port}.

The documentation of this project can be found [\[here\]](https://github.com/VilMano/livrariaaberta.pt/tree/main/Documentation).

