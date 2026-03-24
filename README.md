\# Course Management System API



\## Project Description



This project is an ASP.NET Core Web API for managing courses, instructors, and students.

It demonstrates backend development concepts including database relationships, authentication, authorization, DTO usage, and optimized data querying.



\---



\## Technologies Used



\* \*\*ASP.NET Core Web API\*\*

&#x20; Framework used to build RESTful APIs.



\* \*\*Entity Framework Core\*\*

&#x20; ORM used to interact with SQL Server database.



\* \*\*SQL Server (LocalDB)\*\*

&#x20; Database used to store application data.



\* \*\*JWT Authentication\*\*

&#x20; Used to securely authenticate users and protect API endpoints.



\* \*\*Swagger (Swashbuckle)\*\*

&#x20; Used to document and test API endpoints.



\---



\##  System Architecture



The project follows a clean architecture:



\* \*\*Controllers\*\* → Handle HTTP requests

\* \*\*Services\*\* → Business logic layer

\* \*\*Models\*\* → Database entities

\* \*\*DTOs\*\* → Data transfer objects (for requests \& responses)

\* \*\*DbContext\*\* → Database connection



\---



\## Entity Relationships



\* \*\*One-to-One\*\*

&#x20; Instructor ↔ InstructorProfile



\* \*\*One-to-Many\*\*

&#x20; Instructor → Courses



\* \*\*Many-to-Many\*\*

&#x20; Student ↔ Course (via Enrollment)



\---



\## Authentication \& Authorization



\* Users log in using:



&#x20; ```

&#x20; POST /api/Auth/login

&#x20; ```



\* A \*\*JWT token\*\* is returned.



\* This token must be sent in the request header:



&#x20; ```

&#x20; Authorization: Bearer YOUR\_TOKEN

&#x20; ```



\* Role-based authorization is implemented:



&#x20; \* Admin → Can create/update courses

&#x20; \* Other users → Limited access



\---



\## DTO Usage



DTOs are used to:



\* Control data sent/received

\* Improve security

\* Prevent exposing full database models



Types used:



\* Create DTO

\* Update DTO

\* Read DTO



\---



\## Validation



Data validation is implemented using Data Annotations:



\* `\[Required]`

\* `\[MaxLength]`

\* `\[Range]`



Invalid requests return \*\*HTTP 400 Bad Request\*\*.



\---



\## LINQ Optimization



\* Used `.Select()` to return only required data

\* Avoided returning full entities



\---



\## AsNoTracking



\* Used `.AsNoTracking()` for read-only queries

\* Improves performance by disabling tracking



\---



\## How to Run the Project



1\. Open terminal in project folder

2\. Run:



```

dotnet restore

dotnet ef database update

dotnet run

```



3\. Open Swagger:



```

https://localhost:XXXX/swagger

```



\---



\##  API Endpoints



\### Authentication



\* `POST /api/Auth/login`



\### Courses



\* `GET /api/Course`

\* `POST /api/Course` (Admin only)

\* `PUT /api/Course/{id}` (Admin only)



\### Instructor



\* `GET /api/Instructor`

\* `POST /api/Instructor`



\### Student



\* `GET /api/Student`



\---



\## Why HTTP-Only Cookies Are Important



HTTP-only cookies are commonly used in authentication because:



\* They \*\*cannot be accessed by JavaScript\*\*

\* Protect against \*\*XSS (Cross-Site Scripting) attacks\*\*

\* Automatically sent with every request

\* Improve security compared to storing tokens in local storage



Although this project uses JWT in headers, HTTP-only cookies are widely used in industry for better security.



\---



\## Screenshots



The project includes screenshots showing:



\* Swagger UI

\* Login request (JWT token)

\* Authorized requests

\* Creating instructor

\* Creating course



\---



\## AI Usage



AI tools were used to:



\* Assist with debugging



Screenshots of AI interaction are included as required in folder "ChatScreenshots"



\---



\## Conclusion



This project successfully demonstrates:



\* Secure API development

\* Clean architecture

\* Database relationships

\* Authentication \& authorization

\* Performance optimization



\---



