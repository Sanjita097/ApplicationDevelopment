using System;
class Teacher
{
    // property of teacher
    public string Name{get; set;}
    
    // virtual method
    public virtual void Teaching()
    {
        Console.WriteLine("Teacher teaches in English");
    }
    // Another method
    public  void SalaryInfo()
    {
        Console.WriteLine("Teacher salary info: Rs.25000");
    }
}

// Derived class NepaliTeacher
class NepaliTeacher: Teacher
{
    // Override teaching method
    public override void Teaching()
    {
        base.Teaching();
        Console.WriteLine("Nepali Teacher teaches in Nepali");
    }
}

// Derived class EnglishTeacher
class EnglishTeacher:Teacher
{
//  No need to override because it is not necessary to be override the teaching() method.
}