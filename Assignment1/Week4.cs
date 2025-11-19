
namespace Workshop2
{

    //---Task 1----//

    public class Student
    {
        // Instance fields
        public string name;
        public int age;
        public string faculty;

        // Static field
        public static string collegeName = "ABC College";
    }

    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Creating first object
            Student s1 = new Student();
            s1.name = "Ram";
            s1.age = 20;
            s1.faculty = "BCA";

            // Creating second object
            Student s2 = new Student();
            s2.name = "Sita";
            s2.age = 22;
            s2.faculty = "CSIT";

            // Displaying values of first object
            Console.WriteLine("---- Student 1 ----");
            Console.WriteLine("Name: " + s1.name);
            Console.WriteLine("Age: " + s1.age);
            Console.WriteLine("Faculty: " + s1.faculty);

            // Displaying values of second object
            Console.WriteLine("\n---- Student 2 ----");
            Console.WriteLine("Name: " + s2.name);
            Console.WriteLine("Age: " + s2.age);
            Console.WriteLine("Faculty: " + s2.faculty);

            // Display static field
            Console.WriteLine("\nCollege Name (Static Field): " + Student.collegeName);
        }
    }







    ////---Task 2----//
    //public class Calculator
    //{
    //    // 1. Void method
    //    public void PrintWelcome()
    //    {
    //        Console.WriteLine("Welcome to the Calculator");
    //    }

    //    // 2. Add method
    //    public int Add(int num1, int num2)
    //    {
    //        return num1 + num2;
    //    }

    //    // 3. Multiply method with optional parameter
    //    public int Multiply(int num1, int num2 = 1)
    //    {
    //        return num1 * num2;
    //    }
    //}

    //using System;

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Create object of Calculator
    //        Calculator calc = new Calculator();

    //        // Call PrintWelcome()
    //        calc.PrintWelcome();

    //        // Call Add()
    //        int sum = calc.Add(5, 10);
    //        Console.WriteLine("Addition: " + sum);

    //        // Call Multiply() with two parameters
    //        int product1 = calc.Multiply(4, 3);
    //        Console.WriteLine("Multiplication (4 * 3): " + product1);

    //        // Call Multiply() with only one parameter (optional param used)
    //        int product2 = calc.Multiply(7);
    //        Console.WriteLine("Multiplication with default value (7 * 1): " + product2);
    //    }
    //}








    ////---Task 3----//
    //public class ParameterDemo
    //{
    //    // 1. Increase using ref parameter
    //    public void Increase(ref int number)
    //    {
    //        number += 10;
    //    }

    //    // 2. Assign full name using out parameter
    //    public void GetFullName(out string fullname)
    //    {
    //        fullname = "Aagam Parajuli";   // Put your full name here
    //    }

    //    // 3. Sum of all numbers using params
    //    public int SumAll(params int[] numbers)
    //    {
    //        int sum = 0;

    //        foreach (int num in numbers)
    //        {
    //            sum += num;
    //        }

    //        return sum;
    //    }
    //}

    //using System;

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Create object of ParameterDemo
    //        ParameterDemo demo = new ParameterDemo();

    //        // ---------- 1. Calling Increase(ref int) ----------
    //        int value = 20;
    //        demo.Increase(ref value);
    //        Console.WriteLine("After Increase: " + value);

    //        // ---------- 2. Calling GetFullName(out string) ----------
    //        string myFullName;
    //        demo.GetFullName(out myFullName);
    //        Console.WriteLine("Full Name: " + myFullName);

    //        // ---------- 3. Calling SumAll(params int[]) ----------
    //        int total = demo.SumAll(5, 10, 15, 20);
    //        Console.WriteLine("Sum of all numbers: " + total);
    //    }
    //}







    ////---Task 4----//
    //public class Player
    //{
    //    // Instance fields
    //    public string playerName;
    //    public int level;
    //    public int health;

    //    // Default constructor
    //    public Player()
    //    {
    //        Console.WriteLine("Default constructor has been called");
    //    }

    //    // Parameterized constructor
    //    public Player(string name, int lvl, int hp)
    //    {
    //        playerName = name;
    //        level = lvl;
    //        health = hp;
    //    }
    //}


    //using System;

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Object using default constructor
    //        Player p1 = new Player();
    //        Console.WriteLine("Player 1 Name: " + p1.playerName);
    //        Console.WriteLine("Player 1 Level: " + p1.level);
    //        Console.WriteLine("Player 1 Health: " + p1.health);

    //        Console.WriteLine("--------------------------------");

    //        // Object using parameterized constructor
    //        Player p2 = new Player("Aagam", 5, 100);
    //        Console.WriteLine("Player 2 Name: " + p2.playerName);
    //        Console.WriteLine("Player 2 Level: " + p2.level);
    //        Console.WriteLine("Player 2 Health: " + p2.health);
    //    }
    //}








    ////---Task 5----//
    //public enum DayType
    //{
    //    Weekday,
    //    Weekend
    //}

    //public record Book(string title, string author, double price);

    //using System;

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // ------------------- Part 1: Enum and Day Checking -------------------
    //        Console.Write("Enter a day: ");
    //        string dayInput = Console.ReadLine();

    //        dayInput = dayInput.ToLower(); // convert to lowercase for easy checking

    //        DayType type;

    //        if (dayInput == "friday" || dayInput == "saturday")
    //        {
    //            type = DayType.Weekend;
    //        }
    //        else
    //        {
    //            type = DayType.Weekday;
    //        }

    //        Console.WriteLine("It is: " + type);
    //        Console.WriteLine("--------------------------------------");

    //        // ------------------- Part 2: Record and with Expression -------------------

    //        // Create first object
    //        Book b1 = new Book("C# Basics", "Aagam Parajuli", 799.50);

    //        // Create second using with expression (change title and price)
    //        Book b2 = b1 with { title = "Advanced C#", price = 999.99 };

    //        // Print first object
    //        Console.WriteLine("Book 1:");
    //        Console.WriteLine($"Title: {b1.title}, Author: {b1.author}, Price: {b1.price}");

    //        Console.WriteLine("--------------------------------------");

    //        // Deconstruct second object
    //        var (title2, author2, price2) = b2;

    //        Console.WriteLine("Book 2 (Deconstructed):");
    //        Console.WriteLine("Title: " + title2);
    //        Console.WriteLine("Author: " + author2);
    //        Console.WriteLine("Price: " + price2);
    //    }
    //}








    ////---Task 6----//
    //using System;

    //class Program
    //{
    //    static void Main()
    //    {
    //        // Ask user for marks
    //        Console.Write("Enter marks: ");
    //        string marksInput = Console.ReadLine();

    //        // TryParse for marks
    //        int marks;
    //        bool isMarksValid = int.TryParse(marksInput, out marks);

    //        // Ask user for total
    //        Console.Write("Enter total: ");
    //        string totalInput = Console.ReadLine();

    //        // TryParse for total
    //        int total;
    //        bool isTotalValid = int.TryParse(totalInput, out total);

    //        // Check if both inputs are valid
    //        if (!isMarksValid || !isTotalValid)
    //        {
    //            Console.WriteLine("Invalid input! Please enter valid integers.");
    //            return;
    //        }

    //        // BREAKPOINT 1: Set breakpoint here before calculation

    //        // ? WRONG calculation (integer division problem)
    //        // double percentage = marks / total * 100;

    //        // ? CORRECT calculation: convert to double before dividing
    //        double percentage = (double)marks / total * 100;

    //        // BREAKPOINT 2: Set breakpoint here after calculation

    //        Console.WriteLine("Percentage = " + percentage + "%");
    //    }
    //}










    //---Task 7----//
    // Task in doc file









}