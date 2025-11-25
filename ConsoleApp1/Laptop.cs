using System;
 // Derived class Laptop
    class Laptop : ElectronicDevice
    {
        // constructor
        public Laptop(String brand, double price) : base(brand, price)
        {

        }
        // Extra method
        public void TrunOnBattery()
        {
            Console.WriteLine($"{Brand} laptop is ON now.");
        }

        // override Info method
        public override void ShowInfo()
        {
            Console.WriteLine("laptop Details.");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Price:Rs.{Price}");
        }
    }