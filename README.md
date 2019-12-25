# CourseLibraryAPI
RESTful API Using ASP.NET Core 3.0

## Get list of Authors

### Request
  /api/authors

### Respond

HTTP/1.1 200 OK <br/>
Date: Wed, 25 Dec 2019 15:38:17 GMT <br/>
Status: 200 OK <br/>
Content-Type: application/json; charset=utf-8 <br/>
Transfer-Encoding: chunked <br/>

[
    {
        "id": "5b3621c0-7b12-4e80-9c8b-3398cba7ee05",
        "name": "Seabury Toxic Reyson",
        "age": 329
    },
    {
        "id": "2ee49fe3-edf2-4f91-8409-3eb25ce6ca51",
        "name": "Atherton Crow Ridley",
        "age": 298
    }
]
