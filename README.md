# Library Management System - LINQ Join Example

This project demonstrates how to use LINQ `join` to merge two data tables in a simple library management system using C#. The example focuses on combining a list of authors and a list of books to display the book titles and their respective authors.

## Project Structure

### Classes

- **`Author`**: Represents the `Authors` table with the following properties:
  - `AuthorId` (int): Unique identifier for the author.
  - `Name` (string): Name of the author.

- **`Book`**: Represents the `Books` table with the following properties:
  - `BookId` (int): Unique identifier for the book.
  - `Title` (string): Title of the book.
  - `AuthorId` (int): Foreign key linking the book to its author.

### Example Data

The application contains predefined example data:

#### Authors Table
| AuthorId | Name           |
|----------|----------------|
| 1        | Orhan Pamuk    |
| 2        | Elif Şafak     |
| 3        | Ahmet Ümit     |

#### Books Table
| BookId | Title                                    | AuthorId |
|--------|------------------------------------------|----------|
| 1      | Kar                                      | 1        |
| 2      | İstanbul                                 | 1        |
| 3      | 10 Minutes 38 Seconds in This Strange World | 2        |
| 4      | Beyoğlu Rapsodisi                        | 3        |

## How It Works

1. **Data Initialization**: Two lists (`authors` and `books`) are created to simulate the `Authors` and `Books` tables.
2. **LINQ Join Query**:
   - Combines the `authors` and `books` lists using the `AuthorId` field.
   - Selects a new object containing the book title and author name.
3. **Output**:
   - The query results are displayed in the format: `Book: [Title], Author: [Name]`.

### Sample Output
When the program is executed, the following output is displayed:

```
Books and their Authors:
Book: Kar, Author: Orhan Pamuk
Book: İstanbul, Author: Orhan Pamuk
Book: 10 Minutes 38 Seconds in This Strange World, Author: Elif Şafak
Book: Beyoğlu Rapsodisi, Author: Ahmet Ümit
```

## Usage

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/library-linq-join.git
   ```
2. Open the project in your preferred IDE (e.g., Visual Studio).
3. Build and run the application.

## Prerequisites

- .NET SDK (Core or Framework, compatible with C#)
- A code editor like Visual Studio, Visual Studio Code, or Rider.

## Features

- Demonstrates LINQ `join` to combine multiple data sources.
- Provides a simple way to simulate database-like functionality using C# collections.

## Author

Created by **Batuhan Uzun**
