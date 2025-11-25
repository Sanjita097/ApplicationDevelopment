using System;
class Vehicle
{
    public string Brand { get; set; }
    public string Speed { get; set; }
    public void start()
    {
        Console.WriteLine($"{Brand} is starting");
    }
    public void stop()
    {
        Console.WriteLine($"{Brand} is stoping");
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Speed:{Speed}km/h");
    }
}
// Derived class car
class Car: Vehicle
    {
        public int seats {get; set;}
        // override displayinfo method to include seat
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Seats: {seats}");
        }
    }

    // Derived class motorcycle
    class Motorcycle : Vehicle
    {
        public bool hasCarrier { get; set; }
        // Override DisplayInfo method to include hasCarrier
        public override void DisplayInfo()
        {
            base.DisplayInfo(); //call base class method
            Console.WriteLine($"Has Carrier: {hasCarrier}");
        }
    }
