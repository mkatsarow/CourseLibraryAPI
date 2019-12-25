# CourseLibraryAPI
RESTful API Using ASP.NET Core 3.0

## Get list of Authors

### Request
  GET /api/authors/ <br/>
  http://localhost:51044/api/authors

### Respond

HTTP/1.1 200 OK <br/>
Date: Wed, 25 Dec 2019 15:38:17 GMT <br/>
Status: 200 OK <br/>
Content-Type: application/json; charset=utf-8 <br/>
Transfer-Encoding: chunked <br/>

{
        "id": "5b3621c0-7b12-4e80-9c8b-3398cba7ee05", 
        "name": "Seabury Toxic Reyson",
        "age": 329
    },<br/>
    {
        "id": "2ee49fe3-edf2-4f91-8409-3eb25ce6ca51",
        "name": "Atherton Crow Ridley",
        "age": 298
}

<br/>

## Get one Author

### Request 
  GET /api/authors/{authorId} <br/>
  http://localhost:51044/api/authors/5b3621c0-7b12-4e80-9c8b-3398cba7ee05
  
### Respond

HTTP/1.1 200 OK <br/>
Date: Wed, 25 Dec 2019 15:53:56 GMT <br/>
Status: 200 OK <br/>
Content-Type: application/json; charset=utf-8 <br/>
Transfer-Encoding: chunked <br/>
 
{
    "id": "5b3621c0-7b12-4e80-9c8b-3398cba7ee05",
    "name": "Seabury Toxic Reyson",
    "age": 329
}
<br>

## Get all courses for Author

### Request
  GET /api/authors/{authorId}/courses <br/>
  http://localhost:51044/api/authors/d28888e9-2ba9-473a-a40f-e38cb54f9b35/courses
  
### Respond

HTTP/1.1 200 OK <br/>
Date: Wed, 25 Dec 2019 15:59:01 GMT
Status: 200 OK <br/>
Content-Type: application/json; charset=utf-8 <br/>
Transfer-Encoding: chunked <br/>

 {<br/>
        "id": "5b1c2b4d-48c7-402a-80c3-cc796ad49c6b", <br>
        "title": "Commandeering a Ship Without Getting Caught",  <br>
        "description": "Commandeering a ship in rough waters isn't easy.  Commandeering it without getting caught is even harder.  In                       this course you'll learn how to sail away and avoid those pesky musketeers.", <br>
        "aUthorId": "d28888e9-2ba9-473a-a40f-e38cb54f9b35" <br>
    }, <br/>
    {<br/>
        "id": "d8663e5e-7494-4f81-8739-6e0de1bea7ee", <br/>
        "title": "Overthrowing Mutiny", <br/>
        "description": "In this course, the author provides tips to avoid, or, if needed, overthrow pirate mutiny.", <br/>
        "aUthorId": "d28888e9-2ba9-473a-a40f-e38cb54f9b35" <br/> 
    }
    <br/>
## Get one course

### Request 
  GET /api/authors/{authorId}/courses/{courseId} <br/>
  http://localhost:51044/api/authors/d28888e9-2ba9-473a-a40f-e38cb54f9b35/courses/5b1c2b4d-48c7-402a-80c3-cc796ad49c6b 
 
### Respond

HTTP/1.1 200 OK <br/>
Date: Wed, 25 Dec 2019 16:07:10 GMT
Status: 200 OK <br/>
Content-Type: application/json; charset=utf-8 <br/>
Transfer-Encoding: chunked <br/>

{ <br/>
    "id": "5b1c2b4d-48c7-402a-80c3-cc796ad49c6b", <br/>
    "title": "Commandeering a Ship Without Getting Caught", <br/>
    "description": "Commandeering a ship in rough waters isn't easy.  Commandeering it without getting caught is even harder.  In this course you'll learn how to sail away and avoid those pesky musketeers.", <br/>
    "aUthorId": "d28888e9-2ba9-473a-a40f-e38cb54f9b35" <br/>
}<br/>
