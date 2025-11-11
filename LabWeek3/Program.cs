using System;

namespace LabWeek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create object of Operators class
            Operators op = new Operators();

            Console.WriteLine("Addition: " + op.Add(10, 5));
            Console.WriteLine("Subtraction: " + op.Subtract(10, 5));
            Console.WriteLine("Multiplication: " + op.Multiply(10, 5));
            Console.WriteLine("Division: " + op.Divide(10, 5));

            // Test division by zero
            Console.WriteLine("Division by zero: " + op.Divide(10, 0));

            // Odd/Even check
            op.OddEvenFinder(7);
            op.OddEvenFinder(12);

            Console.WriteLine(); // Blank line for readability

            // Task2
            NullOperations nullOps = new NullOperations();

            // Call PerformNullChecks method
            nullOps.PerformNullChecks();

            //Task3
            Person person = new Person();
            Console.Write("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            person.DisplayAgeGroup(age);

            //Task4
            Console.Write("Enter number(1-7:");
            int dayNumber = int.Parse(Console.ReadLine());
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.Write("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.Write("Wednesday");
                    break;
                case 5:
                    Console.Write("Thursday");
                    break;
                case 6:
                    Console.Write("Friday");
                    break;
                case 7:
                    Console.Write("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;
            }
            //Task 5
            LoopOperations loop = new LoopOperations();
            loop.SumUpToN();
            loop.SumArrayElements();
            loop.PrintNumbers();
            
            //Task 6
            NumberConversion num = new NumberConversion();
            num.ConvertToInteger();
            
            PasswordCheck psw = new PasswordCheck();
            psw.CheckPassword();
            
            Console.ReadKey(); 
        }
    }
}