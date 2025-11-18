using System;

public class Calculator
{
    // Method to print a welcome message
    public void PrintWelcome()
    {
        Console.WriteLine("Welcome to the Calculator");
    }

    // Method to add two numbers and return the result
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // Method to multiply two numbers, with num2 defaulting to 1 if not provided
    public int Multiply(int num1, int num2 = 1)
    {
        return num1 * num2;
    }
}