# Database Connection Pool

[Wiki ]('https://en.wikipedia.org/wiki/Connection_pool')

In software engineering, a connection pool is a cache of database connections maintained so that the connections can be reused when future requests to the database are required. Connection pools are used to enhance the performance of executing commands on a database. Opening and maintaining a database connection for each user, especially requests made to a dynamic database-driven website application, is costly and wastes resources. In connection pooling, after a connection is created, it is placed in the pool and it is used again so that a new connection does not have to be established. If all the connections are being used, a new connection is made and is added to the pool. Connection pooling also cuts down on the amount of time a user must wait to establish a connection to the database.

Application
Web-based and enterprise applications use an application server to handle connection pooling. Dynamic web pages without connection pooling open connections to database services as required and close them when the page is done servicing a particular request. Pages that use connection pooling, on the other hand, maintain open connections in a pool. When the page requires access to the database, it simply uses an existing connection from the pool, and establishes a new connection only if no pooled connections are available. This reduces the overhead associated with connecting to the database to service individual requests.

Local applications that need frequent access to databases can also benefit from connection pooling. Open connections can be maintained in local applications that don't need to service separate remote requests like application servers, but implementations of connection pooling can become complicated. A number of available libraries implement connection pooling and related SQL query pooling, simplifying the implementation of connection pools in database-intensive applications.

Administrators can configure connection pools with restrictions on the numbers of minimum connections, maximum connections and idle connections to optimize the performance of pooling in specific problem contexts and in specific environments.

# Benefit




# Description
- Initializes a resource pool of a specified size (concurrent initialization) to avoid resource race issues through channels.
- Sets Timeout processing to prevent clients from waiting too long.





# Note

[Avoiding Startup service injection in ASP.NET Core 3]('https://andrewlock.net/avoiding-startup-service-injection-in-asp-net-core-3/')