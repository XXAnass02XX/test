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
        Console.WriteLine($"the title is : {Title}, Author: {Author}");
        Console.WriteLine($"-----------");
        Console.WriteLine($"+++++++++++");
    }
}
