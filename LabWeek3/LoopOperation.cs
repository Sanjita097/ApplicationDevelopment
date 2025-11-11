using System;

namespace LabWeek3
{
    internal class LoopOperations
    {
        // Method to calculate sum from 1 to N
        public void SumUpToN()
        {
            Console.Write("Enter a number N: ");
            int N = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum from 1 to {N} is: {sum}");
            Console.WriteLine();
        }

        // Method to print numbers from 1 to 20 with continue and break
        public void PrintNumbers()
        {
            int number = 1;
            Console.WriteLine("Numbers from 1 to 20 (skip multiples of 4, stop at 15):");
            while (number <= 20)
            {
                if (number % 4 == 0)
                {
                    number++;
                    continue; // Skip multiples of 4
                }

                if (number == 15)
                {
                    break; // Stop when number is 15
                }

                Console.Write(number + " ");
                number++;
            }
            Console.WriteLine("\n");
        }

        // Method to sum all elements in an array using foreach
        public void SumArrayElements()
        {
            int[] arr = { 2, 4, 6, 8, 10 }; // Example array
            int arraySum = 0;
            foreach (int item in arr)
            {
                arraySum += item;
            }
            Console.WriteLine("Sum of array elements: " + arraySum);
        }
    }
}