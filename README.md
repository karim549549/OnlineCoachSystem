Architecture
This project follows the n-tier architecture with 3 layers:

Data Access Layer: This layer is responsible for accessing the database using Entity Framework. It abstracts the database access logic using the IRepository interface.
Business Logic Layer: This layer abstracts the business logic out of the controllers. It uses the IRepository interface to interact with the database.
Controllers Layer: This is an ASP.NET 8 project with Web API. It uses the Business Logic Layer to handle requests and send responses.
