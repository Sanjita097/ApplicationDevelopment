using System;

public class CaclulatePercentage
{
    public void CalcPercentage()
    {
        Console.Write("Enter marks: ");
        string marksInput = Console.ReadLine();

        Console.Write("Enter total: ");
        string totalInput = Console.ReadLine();

        // Using TryParse
        bool validMarks = int.TryParse(marksInput, out int marks);
        bool validTotal = int.TryParse(totalInput, out int total);

        if (!validMarks || !validTotal)
        {
            Console.WriteLine("Invalid input! Please enter integer values.");
            return;
        }

        // ----- BREAKPOINT 1: Set a breakpoint here -----
        double percentage = marks / total * 100; // Incorrect due to integer division

        // ----- BREAKPOINT 2: Set a breakpoint here -----
        Console.WriteLine($"Percentage: {percentage}");
    }

    // Corrected version for your explanation:
    public double CorrectPercentage(int marks, int total)
    {
        return (double)marks / total * 100; // Fix: force floating-point division
    }
}