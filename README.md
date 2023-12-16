# Student Management Desktop Application

This project is a desktop application built using C# and MySQL to manage student information efficiently. It provides functionalities to add, delete, update, and view student records.

## Features

- **Add Student:** Add a new student record to the database.
- **Delete Student:** Remove a student record based on their unique code.
- **Update Student:** Modify existing student information.
- **View Students:** Display a list of all students in a table format.

## Installation

To run this application locally, follow these steps:

1. **Clone the repository:**

    ```bash
    https://github.com/ibtissammassa/Students-Management-System.git
    ```

2. **Database Setup:**

    - Set up a MySQL database named `students`.
    - Within this database, create a table named `students` to store student records.
     <br><br>
    ```sql
    CREATE TABLE students (
        Code INT AUTO_INCREMENT PRIMARY KEY,
        Nom VARCHAR(255) NOT NULL,
        Prenom VARCHAR(255) NOT NULL,
        Filiere VARCHAR(255) NOT NULL
    );
    ```
    - Ensure your database connection details are correctly configured in the `StudentsDB.cs` file.
        - Open the `StudentsDB.cs` file in your project.
        - Ensure that the connection string in the `InitialiseDBConnection()` method matches your MySQL database configuration.

3. **Open in IDE:**

    - Open the project in your preferred IDE (such as Visual Studio).

4. **Run the Application:**

    - Build and run the application within your IDE.

## Usage

- Launch the application.
- Use the provided buttons to add, delete, update, and view student records.
- Enter the necessary information in the text fields when adding or updating a student.
