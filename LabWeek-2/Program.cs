// See https://aka.ms/new-console-template for more information
using System;
//Task1
// Console.WriteLine("---Information---");
// Console.Write("Enter your username:");
// string username = Console.ReadLine();
// Console.Write("Enter your luckynumber:");
// string luckynumber = Console.ReadLine();
//
// Console.WriteLine($"Hello {username}! your lucky number is {luckynumber}");

//Task2

// class Circle
// {
//     public const double PI = 3.14; // constant value
//
//     public static double Area(double r) => PI * r * r;
//     public static double Perimeter(double r) => 2 * PI * r;
// }
//
// class CircleProgram
// {
//     static void Main()
//     {
//
//         double radius = 5;
//         Console.WriteLine($"Area: {Circle.Area(radius)}");
//         Console.WriteLine($"Perimeter: {Circle.Perimeter(radius)}");
//     }
// }

//Task3
// class Program
// {
//     static void Main()
//     {
//         // Declare and initialize variables of various data types
//         byte byteVar = 10;
//         short shortVar = 1000;
//         int intVar = 50000;
//         long longVar = 1000000000L;
//         float floatVar = 3.5f;
//         double doubleVar = 9.8765;
//         decimal decimalVar = 123.456m;
//         char charVar = 'A';
//         bool boolVar = true;
//         
//         string intToString = intVar.ToString();   
//         double stringToDouble = Convert.ToDouble("3.14"); 
//         
//         Console.WriteLine("byte   : " + byteVar);
//         Console.WriteLine("short  : " + shortVar);
//         Console.WriteLine("int    : " + intVar);
//         Console.WriteLine("long   : " + longVar);
//         Console.WriteLine("float  : " + floatVar);
//         Console.WriteLine("double : " + doubleVar);
//         Console.WriteLine("decimal: " + decimalVar);
//         Console.WriteLine("char   : " + charVar);
//         Console.WriteLine("bool   : " + boolVar);
//         
//         Console.WriteLine("Converted int (to string): " + intToString);
//         Console.WriteLine("Converted string (to double): " + stringToDouble);
//     }
// }


//Task4
// class Program
// {
//     static void Main()
//     {
//         int[] favoriteNumbers = { 42, 7, 19, 3, 56 };
//         
//         Array.Sort(favoriteNumbers);
//         Console.WriteLine("Array after sorting (ascending):");
//         for (int i = 0; i < favoriteNumbers.Length; i++)
//         {
//             Console.WriteLine(favoriteNumbers[i]);
//         }
//         
//         Array.Reverse(favoriteNumbers);
//         Console.WriteLine("\nArray after reversing (descending):");
//         for (int i = 0; i < favoriteNumbers.Length; i++)
//         {
//             Console.WriteLine(favoriteNumbers[i]);
//         }
//         
//         int searchNumber = 19;
//         int index = Array.IndexOf(favoriteNumbers, searchNumber);
//         
//         if (index != -1)
//             Console.WriteLine($"\nThe number {searchNumber} is found at index: {index}");
//         else
//             Console.WriteLine($"\nThe number {searchNumber} is not found in the array.");
//     }
// }

//Task5
// class Program
// {
//     static void Main()
//     {
//         DateTime birthDate = new DateTime(2003, 6, 15); 
//         DateTime currentDate = DateTime.Now;
//         TimeSpan ageSpan = currentDate - birthDate;
//         int ageInYears = (int)(ageSpan.TotalDays / 365.25);
//         DateTime newDate = birthDate.AddDays(10);
//         
//         Console.WriteLine("Birthdate       : " + birthDate.ToShortDateString());
//         Console.WriteLine("Current Date    : " + currentDate.ToShortDateString());
//         Console.WriteLine("Age in Years    : " + ageInYears);
//         Console.WriteLine("Birthdate + 10 days : " + newDate.ToShortDateString());
//     }
// }

//Task6
// class Program
// {
//     static void Main()
//     {
//         List<string> fruits = new List<string> { "Mango", "Apple", "Banana" };
//         
//         fruits.Add("Orange");
//         
//         fruits.Remove("Apple");
//         
//         Console.WriteLine("List of Fruits:");
//         foreach (string fruit in fruits)
//         {
//             Console.WriteLine("- " + fruit);
//         }
//         
//         Dictionary<int, string> fruitDictionary = new Dictionary<int, string>()
//         {
//             { 1, "Mango" },
//             { 2, "Banana" },
//             { 3, "Orange" }
//         };
//         
//         fruitDictionary.Add(4, "Pineapple");
//         
//         Console.WriteLine("\nFruit Dictionary:");
//         foreach (KeyValuePair<int, string> entry in fruitDictionary)
//         {
//             Console.WriteLine($"ID: {entry.Key}, Fruit: {entry.Value}");
//         }
//     }
// }