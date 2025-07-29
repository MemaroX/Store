# Store

A modern e-commerce web application built with ASP.NET Core MVC, designed to showcase a robust and scalable online store solution.

## Features
- Product listing and details
- Shopping cart functionality
- User authentication and authorization
- Order management
- Database integration using Entity Framework Core

## Technologies Used
- ASP.NET Core MVC (C#)
- .NET 8.0
- Entity Framework Core (for SQL Server)
- HTML, CSS, JavaScript (for frontend)

## Setup Instructions
To get this project up and running on your local machine, follow these steps:

1.  **Clone the repository:**
    ```bash
    git clone https://github.com/MemaroX/Store.git
    cd Store
    ```

2.  **Restore NuGet packages:**
    Open a terminal in the project root directory (`Store`) and run:
    ```bash
    dotnet restore
    ```

3.  **Update database (Migrations):**
    Apply any pending database migrations. Ensure you have a SQL Server instance running and configured in `appsettings.json`.
    ```bash
    dotnet ef database update
    ```

4.  **Run the application:**
    ```bash
    dotnet run
    ```
    The application will typically run on `https://localhost:7000` or `http://localhost:5000`.

## Contributing
Contributions are welcome! Please feel free to fork the repository, make your changes, and submit a pull request.
