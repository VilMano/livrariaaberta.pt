# Aberta API
## Running the project
After cloning the project run the following command inside the AbertaAPI folder:

```
$ docker compose up -d
```

That should be it :]


## Accessing the API
### Endpoints

Get one record based on ISBN
```
[httpGet]

http://localhost:8080/Books/single?isbn=123
```

Get all ordered records paginated [ optional search term ]
```
[httpPost]

http://localhost:8080/Books/all

body: 
{
  "searchTerm": "",
  "sortBy": "alpha",
  "sortOrder": "asc",
  "page": 1,
  "numberOfResults": 50
}
```

