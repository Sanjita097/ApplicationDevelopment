using System;

namespace LabWeek3
{
    internal class NumberConversion
    {
        public void ConvertToInteger()
        {
            try
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                int number = int.Parse(input); // Convert string to int
                Console.WriteLine("You entered: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }
        }
    }
}