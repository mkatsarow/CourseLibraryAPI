# CourseLibraryAPI
RESTful API Using ASP.NET Core 3.0

##Get list of Authors

###Request
  http://localhost:51044/api/authors

###Respond

HTTP/1.1 200 OK
Date: Wed, 25 Dec 2019 15:38:17 GMT
Status: 200 OK
Content-Type: application/json; charset=utf-8
Transfer-Encoding: chunked

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
