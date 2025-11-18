using System;

class Program
{
    static void Main()
    {
        //Task 1
        // Create two objects of Student class
        Student student1 = new Student("John Doe", 16, "10th Grade");
        Student student2 = new Student("Jane Smith", 17, "11th Grade");

        // Display the details for both students
        Console.WriteLine("Student 1 Details:");
        student1.DisplayStudentInfo();

        Console.WriteLine("\nStudent 2 Details:");
        student2.DisplayStudentInfo();

        // Display static field (SchoolName)
        Console.WriteLine("\nStatic Field (School Name): " + Student.SchoolName);
        
        //Task2
        Calculator calc = new Calculator();
        calc.PrintWelcome();
        // Call the Add method and print the result
        int sum = calc.Add(10, 20);
        Console.WriteLine($"The sum of 10 and 20 is: {sum}");

        // Call the Multiply method with one argument (num2 defaults to 1)
        int product1 = calc.Multiply(5);
        Console.WriteLine($"The product of 5 and 1 (default) is: {product1}");

        // Call the Multiply method with two arguments
        int product2 = calc.Multiply(5, 4);
        Console.WriteLine($"The product of 5 and 4 is: {product2}");
        
        //Task 3
        // Create object of ParameterDemo
        ParameterDemo demo = new ParameterDemo();

        // ---- 1. Call Increase using ref ----
        int value = 20;
        demo.Increase(ref value);
        Console.WriteLine("Value after Increase: " + value);

        // ---- 2. Call GetFullName using out ----
        string myName;
        demo.GetFullName(out myName);
        Console.WriteLine("Full Name: " + myName);

        // ---- 3. Call SumAll using params ----
        int total = demo.SumAll(5, 10, 15, 20);
        Console.WriteLine("Sum of all numbers: " + total);
        
        //Task 4
        // Object created using default constructor
        Player p1 = new Player();
        Console.WriteLine("Player 1 Details:");
        Console.WriteLine($"Name: {p1.playerName}");
        Console.WriteLine($"Level: {p1.level}");
        Console.WriteLine($"Health: {p1.health}");
        Console.WriteLine();

        // Object created using parameterized constructor
        Player p2 = new Player("KnightRider", 5, 100);
        Console.WriteLine("Player 2 Details:");
        Console.WriteLine($"Name: {p2.playerName}");
        Console.WriteLine($"Level: {p2.level}");
        Console.WriteLine($"Health: {p2.health}");
        Console.WriteLine();
        
        //Task 5
        TaskManager task = new TaskManager();
        task.CheckDayType();
        task.HandleBookRecord();
        Console.WriteLine();
        
        //Task 6
       CaclulatePercentage caclulatePercentage = new CaclulatePercentage();
       caclulatePercentage.CalcPercentage();
    }
}