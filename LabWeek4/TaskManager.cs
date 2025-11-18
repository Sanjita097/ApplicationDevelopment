using System;

public enum DayType
{
    Weekday,
    Weekend
}

public record Book(string title, string author, double price);

public class TaskManager
{
    public void CheckDayType()
    {
        Console.Write("Enter a day: ");
        string day = Console.ReadLine().Trim().ToLower();

        DayType type;

        if (day == "friday" || day == "saturday")
        {
            type = DayType.Weekend;
        }
        else
        {
            type = DayType.Weekday;
        }

        Console.WriteLine($"It is: {type}");
    }

    public void HandleBookRecord()
    {
        // First object
        Book book1 = new Book("C# Basics", "John Doe", 500.0);

        // Second object using 'with' expression
        Book book2 = book1 with { title = "Advanced C#", price = 750.0 };

        Console.WriteLine("\nFirst Book:");
        Console.WriteLine($"Title: {book1.title}, Author: {book1.author}, Price: {book1.price}");

        // Deconstruct second object
        var (title, author, price) = book2;

        Console.WriteLine("\nDeconstructed Second Book:");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: {price}");
    }
}