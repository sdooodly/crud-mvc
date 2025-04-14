# Model-View-Controller (MVC) Architectural Pattern

MVC is an architectural pattern and organizes the code into three distinct, interconnected parts.

* Model: The brain of the application. It's responsible for managing the **data** and the **business logic**. Think of it as what and how the application is about.
* View: It's responsible for **displaying the data** to the user and capturing any **user input**.
* Controller: It acts as the **intermediary** between the Model and the View. It takes user input from the View, tells the Model what to do with that input, and then decides which View to show to the user based on the Model's changes.

## Sample flow

1.  **User Does Something (View):** You click a button or type in a form on the screen.
2.  **View Tells the Controller:** The View notices your action and tells the Controller about it.
3.  **Controller Talks to the Model:** The Controller figures out what your action means and tells the Model to update some data or do some work.

# CRUD MVC Application - People Management

## Overview

This is a simple web application built with ASP.NET Core MVC that allows you to manage a list of people. It demonstrates the basic CRUD (Create, Read, Update, Delete) operations.  The data is stored in a SQLite database.

![Screenshot of the application](assets/screenshots/screenshot.png)

## Features

* **View People:** 
* **Add People:** 
* **Edit People:** 
* **Delete People:** 
* **Data Persistence:** Uses a SQLite database to store data, so it persists even after the application restarts.

## Technologies Used

* ASP.NET Core MVC
* Entity Framework Core (EF Core)
* SQLite Database
* C#
* HTML
* CSS
* Bootstrap (for basic styling)

## Getting Started

1.  **Prerequisites**
    * .NET 5.0 SDK (or a compatible version)
    * Visual Studio (or another compatible code editor)

2.  **Installation**
    * Clone the repository to your local machine.
    * Open the `crud_mvc.sln` solution file in Visual Studio.

3.  **Configuration**
    * **Database:** The application uses a SQLite database. The database file (`crudmvc.db`) will be created in the project's root directory. The connection string is in `appsettings.json`:
        ```json
        "ConnectionStrings": {
          "DefaultConnection": "Data Source=crudmvc.db"
        }
        ```
    * **NuGet Packages:** The following NuGet packages are used.  They should be restored automatically by Visual Studio.  If not, use the Package Manager Console.
        * `Microsoft.EntityFrameworkCore.Sqlite` (Version 5.0.17)
        * `Microsoft.EntityFrameworkCore.Tools` (Version 5.0.17)
        * `Microsoft.EntityFrameworkCore.Design` (Version 5.0.17)
    4.  **Database Setup (Migrations)**
        * Open the **Package Manager Console** in Visual Studio (Tools > NuGet Package Manager > Package Manager Console).
        * Run the following commands:
            ```powershell
            Add-Migration InitialCreate
            Update-Database
            ```
            This will create the database file and the necessary table.

5.  **Running the Application**
    * In Visual Studio, press the "Run" button to build and run the application.
    * The application will open in your default web browser.

##  Code Structure
* `Controllers/PeopleController.cs`: Handles HTTP requests for managing people.
* `Models/Person.cs`: Defines the `Person` data model.
* `Services/PersonService.cs`:  Handles the business logic for managing people, and interacts with the database.
* `Data/ApplicationDbContext.cs`:  EF Core Data Context for interacting with the database.
* `Views/People`: Contains the CSHTML views for displaying and editing data.
* `Migrations`: Contains EF Core migration files.
* `appsettings.json`:  Configuration file (holds the database connection string).

##  Important Notes
* The application uses Entity Framework Core for database interactions.
* The `Update-Database` command needs to be executed whenever changes are made to the `Person` model that affect the database schema.

4.  **Model Does Its Thing:** The Model updates its data or performs the requested logic.
5.  **Controller Chooses a View:** The Controller then decides which View should be shown to the user next,  based on the changes in the Model.
6.  **View Shows the Data:** The chosen View asks the Model for the necessary data and displays it on the screen.

## MVC and OOP

MVC provides a high-level structure, while OOP provides the building blocks within that structure taking advantage of concepts like encapsulation to keep their internal workings separate and inheritance to reuse code. 
