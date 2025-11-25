using System;
class Printer
{
    // print string message
    public void Print(String message)
    {
        Console.WriteLine($"Message:{message}");
    }

    // print integer number
    public void Print(int number)
    {
        Console.WriteLine($"Number:{number}");
    }

    // ptint message multiple times
    public void Print(String message, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{i + 1}. {message}");
        }
    }
}