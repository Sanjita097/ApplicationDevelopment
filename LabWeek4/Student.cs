using System;

public class Student
{
    // Instance fields
    public string Name;
    public int Age;
    public string Grade;

    // Static field (shared across all instances)
    public static string SchoolName = "ABC High School";

    // Constructor to initialize instance fields
    public Student(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }

    // Method to display the instance and static fields
    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Grade: {Grade}");
        Console.WriteLine($"School: {SchoolName}"); // Static field accessed
    }
}