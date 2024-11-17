// Create the Authors table
using LinqJoinLibraryManagement.Models;

var authors = new List<Author>
            {
                new Author { AuthorId = 1, Name = "Orhan Pamuk" },
                new Author { AuthorId = 2, Name = "Elif Şafak" },
                new Author { AuthorId = 3, Name = "Ahmet Ümit" }
            };

// Create the Books table
var books = new List<Book>
            {
                new Book { BookId = 1, Title = "Kar", AuthorId = 1 },
                new Book { BookId = 2, Title = "İstanbul", AuthorId = 1 },
                new Book { BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorId = 2 },
                new Book { BookId = 4, Title = "Beyoğlu Rapsodisi", AuthorId = 3 }
            };

// LINQ Join query
var bookAuthorJoin = from book in books
                     join author in authors
                     on book.AuthorId equals author.AuthorId
                     select new
                     {
                         BookTitle = book.Title,
                         AuthorName = author.Name
                     };

// Print the results
Console.WriteLine("Books and their Authors:");
foreach (var item in bookAuthorJoin)
{
    Console.WriteLine($"Book: {item.BookTitle}, Author: {item.AuthorName}");
}

Console.ReadLine(); // Keep the console window open