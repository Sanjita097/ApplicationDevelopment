using System;
using System.ComponentModel;
class Program
{
    static void Main(string[] args)
    {
        // Task 1

        // Create BankAccount object
        BankAccount myAccount = new BankAccount("ACC12345", 1000);

        // Display account number
        Console.WriteLine($"Account Number: {myAccount.AccountNumber}");

        // Deposit money
        myAccount.Deposit(500);

        // Withdraw money
        myAccount.Withdraw(300);

        // Print remaining balance
        Console.WriteLine($"Remaining Balance: {myAccount.Balance:C}");

        // Task 2
        // Create  car object
        Car myCar = new Car
        {
            Brand = "Toyota",
            Speed = "180",
            seats = 5
        };
        // Create motorcycle object
        Motorcycle motorcycle = new Motorcycle
        {
            Brand = "Vespa",
            Speed = "120",
            hasCarrier = true
        };
        // call car  methods
        myCar.start();
        myCar.DisplayInfo();
        myCar.stop();
        Console.WriteLine();

        // call motorcycle methods
        motorcycle.start();
        motorcycle.DisplayInfo();
        motorcycle.stop();

        // Task 3
        // Create object of printer
        Printer printer = new Printer();
        printer.Print("Hello! I am Sanjita");
        printer.Print(20);
        printer.Print("Sanjita Chaudhary", 5);

        // create object of NepaliTeacher
        NepaliTeacher nepaliTeacher = new NepaliTeacher
        {
            Name = "Khilendra Chaudhary"
        };
        Console.WriteLine($"Name:{nepaliTeacher.Name}");
        nepaliTeacher.Teaching(); //calls override method
        nepaliTeacher.SalaryInfo(); //calls sealed method

        // create object of EnglishTeacher
        EnglishTeacher englishTeacher = new EnglishTeacher
        {
            Name = "Sabin Chaudhary"
        };
        Console.WriteLine($"Name:{englishTeacher.Name}");
        englishTeacher.Teaching(); //Calls override method
        englishTeacher.SalaryInfo(); //calls sealed method

        // Task 4
        // create car object
        CarVehicle carVehicle = new CarVehicle();
        carVehicle.Display(); //Concrete method from base class
        carVehicle.StartEngine(); //asbstract method implemented in car
        carVehicle.StopEngine(); //asbstract method implemented in car

        // create bike object
        Bike bike = new Bike();
        bike.Display(); //Concrete method from base class
        bike.StartEngine(); //asbstract method implemented in bike
        bike.StopEngine(); //asbstract method implemented in car

        // Task 5
        // Create laptop object
        Laptop laptop = new Laptop("MacBook Air M1", 155000);
        laptop.ShowInfo();
        laptop.TrunOnBattery();

        // create smartphone object 
        SmartPhone smartPhone = new SmartPhone("Apple", 120000);
        smartPhone.ShowInfo();
        smartPhone.EnableCamera();

        // create Electronics store object
        ElectronicsStore electronicsStore = new ElectronicsStore();

        // create device
        Laptop laptop1 = new Laptop("MacBook Pro M4", 250000);
        SmartPhone smartPhone1 = new SmartPhone("Samsung s25", 190000);

        // Add device to the store
        electronicsStore.AddDevice(laptop1);
        electronicsStore.AddDevice(smartPhone1);

        // show all devices
        electronicsStore.ShowAllDeviceInfo();

        // Remove a device
        electronicsStore.RemoveDevice(laptop1);

        // show remaining devices
        electronicsStore.ShowAllDeviceInfo();




    }
}