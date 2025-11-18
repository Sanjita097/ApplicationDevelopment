using System;

public class ParameterDemo
{
    // Method using ref parameter
    public void Increase(ref int number)
    {
        number += 10;
    }

    // Method using out parameter
    public void GetFullName(out string fullname)
    {
        fullname = "John Michael Doe";   // Assign any full name here
    }

    // Method using params keyword
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}