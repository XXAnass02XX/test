using System;

public class Program
{
    public static void Main()
    {
        Library lib = new Library();

        Book b1 = new Book("1984", "George Orwell");
        Book b2 = new Book("The Hobbit", "J.R.R. Tolkien");

        lib.AddBook(b1);
        lib.AddBook(b2);

        lib.ShowAllBooks();
    }
}
