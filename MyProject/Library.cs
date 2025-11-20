using System;
using System.Collections.Generic;

public class Library
{
    private List<Book> books = new();

    public void AddBook(Book b)
    {
        books.Add(b);
        Console.WriteLine($"Added: {b.Title}");
    }

    public void ShowAllBooks()
    {
        Console.WriteLine("\nLibrary Books:");
        foreach (var book in books)
        {
            book.PrintInfo();
        }
    }
}
