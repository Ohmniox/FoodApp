# Food App

A small food application which can be used in the stores like McD, Pizza Hut, etc food chain restaurants.
The app is based on the ASP.NET Core 3.1, Entity Framework Core and utilizes JWT for handling authentication.



Database:
The app utilizes the EntityFramework Core code first approach. To initialize the database, set the **FoodApp.API** project as startup project. 
The database connection string needs to specified in this project's `appsettings.json` file in "`FoodAppDBConnectionString`" property.

Open the package manager console and fire the command: `update-database`
This will apply all the migration to the database to create the schema and also seed the initial data into the database.

API Documentation:
Swagger can be accessed using the `/swagger` endpoint
![ScreenShot](/gitassets/Swagger.png)


## Flow
All APIs needs Authorization bearer token to access them. This token can be obtained by `/api/Auth/acquire-token` API.

There are two types of user in this system, Admin and Consumer.
**Admin Credentials:**
Email : admin@foodapp.com
Password: 123

Admin can perform all the actions whereas Consumer can only place order and get the order summary.
Admin users can perform the CRUD operation on the food entity and it can be achieved using the `api/admin/food` endpoints.

## Data Model
![ScreenShot](/gitassets/DataModel.jpg)
