Command Query Responsibility Segregation (CQRS) is a system architecture that extends the idea behind command–query separation (CQS) to the level of services. 
Such a system will have separate interfaces to send queries and to send commands. 
As in CQRS, fulfilling a query request will only retrieve data and will not modify the state of the system (with some exceptions like logging access), 
while fulfilling a command request will modify the state of the system.

In this solution I use .NET Core framework, which is 8.0 version.

I use some nuget packages like
i) Microsoft.EntityFrameworkCore
ii) Microsoft.EntityFrameworkCore.SqlServer
iii) Microsoft.EntityFrameworkCore.Tools
iv) MediatR
v) AutoMapper

I am trying my best to learn you easily.

