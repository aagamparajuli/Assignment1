namespace Workshop2
{

    //------------TASK-1---------------//

    class Program
    {
        static void Main(string[] args)
        {
            // Creating bank account object
            BankAccount acc = new BankAccount("ACC12345", 5000);

            // Show account number
            Console.WriteLine("Account Number: " + acc.AccountNumber);

            // Deposit money
            acc.Deposit(2000);

            // Withdraw money
            acc.Withdraw(1500);

            // Print remaining balance
            Console.WriteLine("Remaining Balance: " + acc.Balance);
        }
    }

    public class BankAccount
    {
        // Private fields
        private string accountNumber;
        private double balance;

        // Constructor to set account number and initial balance
        public BankAccount(string accNum, double initialBalance)
        {
            accountNumber = accNum;

            if (initialBalance > 0)
                balance = initialBalance;
            else
                balance = 0; // default if invalid
        }

        // Read-only property for Account Number
        public string AccountNumber
        {
            get { return accountNumber; }
        }

        // Balance property (set is private)
        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value > 0)     // only positive values are allowed
                    balance = value;
            }
        }

        // Method to deposit money
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount!");
            }
        }

        // Method to withdraw money
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}");
            }
            else
            {
                Console.WriteLine("Invalid withdraw amount!");
            }
        }
    }








    //------------TASK-2---------------//

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Creating Car object
    //        Car car = new Car();
    //        car.Brand = "Toyota";
    //        car.Speed = 120;
    //        car.Seats = 5;

    //        // Creating Motorcycle object
    //        Motorcycle moto = new Motorcycle();
    //        moto.Brand = "Yamaha";
    //        moto.Speed = 150;
    //        moto.Type = "Sports";

    //        // Using base class methods (code reusability)
    //        car.Start();
    //        car.DisplayInfo();
    //        car.Stop();

    //        Console.WriteLine();

    //        moto.Start();
    //        moto.DisplayInfo();
    //        moto.Stop();
    //    }
    //}

    //// Base Class
    //public class Vehicle
    //{
    //    public string Brand { get; set; }
    //    public int Speed { get; set; }

    //    public void Start()
    //    {
    //        Console.WriteLine($"{Brand} is starting...");
    //    }

    //    public void Stop()
    //    {
    //        Console.WriteLine($"{Brand} is stopping...");
    //    }

    //    public virtual void DisplayInfo()
    //    {
    //        Console.WriteLine($"Brand: {Brand}");
    //        Console.WriteLine($"Speed: {Speed} km/h");
    //    }
    //}

    //// Derived Class: Car
    //public class Car : Vehicle
    //{
    //    public int Seats { get; set; }

    //    public override void DisplayInfo()
    //    {
    //        base.DisplayInfo();              // Reuse base class code
    //        Console.WriteLine($"Seats: {Seats}");
    //    }
    //}

    //// Derived Class: Motorcycle
    //public class Motorcycle : Vehicle
    //{
    //    public string Type { get; set; }      // e.g. "Sports", "Cruiser"

    //    public override void DisplayInfo()
    //    {
    //        base.DisplayInfo();               // Reuse base class code
    //        Console.WriteLine($"Type: {Type}");
    //    }
    //}










    //------------TASK-3---------------//

    //public class Printer
    //{
    //    // Method 1: Print a string message
    //    public void Print(string message)
    //    {
    //        Console.WriteLine("Message: " + message);
    //    }

    //    // Method 2: Print an integer number
    //    public void Print(int number)
    //    {
    //        Console.WriteLine("Number: " + number);
    //    }

    //    // Method 3: Print a message multiple times
    //    public void Print(string message, int count)
    //    {
    //        for (int i = 0; i < count; i++)
    //        {
    //            Console.WriteLine(message);
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Printer p = new Printer();

    //        p.Print("Hello World!");    // string
    //        p.Print(25);                // int
    //        p.Print("Repeat Me", 3);    // string + int
    //    }
    //}










    //------------TASK-4---------------//

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Nepali Teacher Object
    //        NepaliTeacher nt = new NepaliTeacher();
    //        nt.Name = "Ram";
    //        Console.WriteLine("Name: " + nt.Name);
    //        nt.Teaching();
    //        nt.SalaryInfo();

    //        Console.WriteLine();

    //        // English Teacher Object
    //        EnglishTeacher et = new EnglishTeacher();
    //        et.Name = "Shyam";
    //        Console.WriteLine("Name: " + et.Name);
    //        et.Teaching();      // Uses base class method
    //        et.SalaryInfo();
    //    }
    //}

    //// Base Class
    //public class Teacher
    //{
    //    public string Name { get; set; }

    //    public virtual void Teaching()
    //    {
    //        Console.WriteLine("Teacher teaches in English");
    //    }

    //    // Method that cannot be overridden → use sealed
    //    public sealed void SalaryInfo()
    //    {
    //        Console.WriteLine("Salary is provided monthly.");
    //    }
    //}

    //// Derived Class 1
    //public class NepaliTeacher : Teacher
    //{
    //    public override void Teaching()
    //    {
    //        Console.WriteLine("Nepali Teacher teaches in Nepali language");
    //    }
    //}

    //// Derived Class 2
    //public class EnglishTeacher : Teacher
    //{
    //    // No need to override Teaching()
    //    // It will use the default version from Teacher class
    //}









    //------------TASK-5---------------//

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Car object
    //        Car car = new Car();
    //        car.Display();
    //        car.StartEngine();
    //        car.StopEngine();

    //        Console.WriteLine();

    //        // Bike object
    //        Bike bike = new Bike();
    //        bike.Display();
    //        bike.StartEngine();
    //        bike.StopEngine();
    //    }
    //}

    //// Abstract Base Class
    //public abstract class Vehicle
    //{
    //    // Abstract methods (must be implemented in child classes)
    //    public abstract void StartEngine();
    //    public abstract void StopEngine();

    //    // Concrete method
    //    public void Display()
    //    {
    //        Console.WriteLine("This is a vehicle");
    //    }
    //}

    //// Derived Class: Car
    //public class Car : Vehicle
    //{
    //    public override void StartEngine()
    //    {
    //        Console.WriteLine("Car engine started.");
    //    }

    //    public override void StopEngine()
    //    {
    //        Console.WriteLine("Car engine stopped.");
    //    }
    //}

    //// Derived Class: Bike
    //public class Bike : Vehicle
    //{
    //    public override void StartEngine()
    //    {
    //        Console.WriteLine("Bike engine started.");
    //    }

    //    public override void StopEngine()
    //    {
    //        Console.WriteLine("Bike engine stopped.");
    //    }
    //}









    //------------TASK-6---------------//

    //public abstract class ElectronicDevice
    //{
    //    // Private fields
    //    private string brand;
    //    private double price;

    //    // Public properties (Encapsulation)
    //    public string Brand
    //    {
    //        get { return brand; }
    //        set { brand = value; }
    //    }

    //    public double Price
    //    {
    //        get { return price; }
    //        set
    //        {
    //            if (value > 0)
    //                price = value;
    //        }
    //    }

    //    // Constructor
    //    public ElectronicDevice(string brand, double price)
    //    {
    //        Brand = brand;
    //        Price = price;
    //    }

    //    // Abstract method
    //    public abstract void ShowInfo();
    //}










    //------------TASK-7---------------//

    //public class Laptop : ElectronicDevice
    //{
    //    // Constructor passes values to base class constructor
    //    public Laptop(string brand, double price) : base(brand, price) { }

    //    // Extra method
    //    public void TurnOnBattery()
    //    {
    //        Console.WriteLine("Laptop battery is now ON.");
    //    }

    //    // Override abstract method
    //    public override void ShowInfo()
    //    {
    //        Console.WriteLine("Laptop Details:");
    //        Console.WriteLine($"Brand: {Brand}");
    //        Console.WriteLine($"Price: Rs. {Price}");
    //    }
    //}

    //public class Smartphone : ElectronicDevice
    //{
    //    // Constructor passes values to base class constructor
    //    public Smartphone(string brand, double price) : base(brand, price) { }

    //    // Extra method
    //    public void EnableCamera()
    //    {
    //        Console.WriteLine("Smartphone camera enabled.");
    //    }

    //    // Override abstract method
    //    public override void ShowInfo()
    //    {
    //        Console.WriteLine("Smartphone Details:");
    //        Console.WriteLine($"Brand: {Brand}");
    //        Console.WriteLine($"Price: Rs. {Price}");
    //    }
    //}










    //------------TASK-8---------------//

    //using System;
    //using System.Collections.Generic;

    //public class ElectronicsStore
    //{
    //    // List to store ElectronicDevice objects
    //    private List<ElectronicDevice> devices = new List<ElectronicDevice>();

    //    // Add a new device
    //    public void AddDevice(ElectronicDevice device)
    //    {
    //        devices.Add(device);
    //        Console.WriteLine("Device added to store.");
    //    }

    //    // Remove a device
    //    public void RemoveDevice(ElectronicDevice device)
    //    {
    //        if (devices.Contains(device))
    //        {
    //            devices.Remove(device);
    //            Console.WriteLine("Device removed from store.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Device not found in store.");
    //        }
    //    }

    //    // Display all device information + downcasting
    //    public void ShowAllDeviceDetails()
    //    {
    //        Console.WriteLine("\n--- All Electronics in Store ---");

    //        foreach (var device in devices)
    //        {
    //            // Call the overridden ShowInfo()
    //            device.ShowInfo();

    //            // Downcast to call child-specific methods
    //            if (device is Laptop laptop)
    //            {
    //                laptop.TurnOnBattery();
    //            }
    //            else if (device is Smartphone phone)
    //            {
    //                phone.EnableCamera();
    //            }

    //            Console.WriteLine();
    //        }
    //    }
    //}










    //------------TASK-9---------------//

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Create the electronics store
    //        ElectronicsStore store = new ElectronicsStore();

    //        // Create Laptop and Smartphone objects
    //        Laptop laptop1 = new Laptop("Dell", 85000);
    //        Smartphone phone1 = new Smartphone("Samsung", 45000);

    //        // Add devices to store
    //        store.AddDevice(laptop1);
    //        store.AddDevice(phone1);

    //        // Display all device details + child specific behavior
    //        store.ShowAllDeviceDetails();
    //    }
    //}



}
