

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
To run this project in its fullest, you must install <b>Docker</b>.



### <ins>**Running**</ins>

First of all, clone the project

    $ git clone git@github.com:VilMano/livrariaaberta.pt.git
    $ cd livrariaaberta.pt

Now you are presented with three folders (BackOffice, API, Scanner). 
Edit the appsettings.json files and run:

Warning: Edit the appsettings.cs file before running the container.

    $ docker compose up -d

That should be all for the project to be up, just open your browser and check the BackOffice frontend:

    http://localhost:8082/


\
Hangfire (Scanner project) can be found at http://localhost:8083/hangfire and the API can be reached at http://localhost:8081.

The documentation of this project can be found [\[here\]](https://github.com/VilMano/livrariaaberta.pt/wiki).

