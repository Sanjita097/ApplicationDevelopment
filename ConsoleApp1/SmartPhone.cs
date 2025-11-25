 // Derived class Laptop
    class SmartPhone : ElectronicDevice
    {
        // constructor
        public SmartPhone(String brand, double price) : base(brand, price)
        {

        }
        // Extra method
        public void EnableCamera()
        {
            Console.WriteLine($"{Brand} smartphone camera is enabled now.");
        }

        // override Info method
        public override void ShowInfo()
        {
            Console.WriteLine("laptop Details.");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Price:Rs.{Price}");
        }
    }