using System;

public class Book
{
    public string Title { get; }
    public string Author { get; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}");
        Console.WriteLine($"feature");
    }

    public void funcAnass()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}");
    }
}
