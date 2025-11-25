using System;
abstract class abstractVehicle
{
    public abstract void StartEngine();
    public abstract void StopEngine();

    // create concrete method
    public void Display()
    {
        Console.WriteLine("This is a vehicle");
    }
}
// Derived class Car
class CarVehicle : abstractVehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started");
    }
    public override void StopEngine()
    {
        Console.WriteLine("Car engine has stopped");
    }
}

// Derived class Bike
class Bike : abstractVehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Bike has started");
    }
    public override void StopEngine()
    {
        Console.WriteLine("Bike has stopped");
    }
}