using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
        // ------Task 1------ 

    public class Operators
    {
        // Method to add two numbers
        public void Add(int a, int b)
        {
            Console.WriteLine("Sum: " + (a + b));
        }

        // Method to subtract two numbers
        public void Subtract(int a, int b)
        {
            Console.WriteLine("Difference: " + (a - b));
        }

        // Method to multiply two numbers
        public void Multiply(int a, int b)
        {
            Console.WriteLine("Product: " + (a * b));
        }

        // Method to divide two numbers
        public void Divide(int a, int b)
        {
            if (b != 0)
                Console.WriteLine("Quotient: " + ((double)a / b));
            else
                Console.WriteLine("Error: Division by zero is not allowed.");
        }
    }

    // Main program class
    internal class Program
    {
        static void Main()
        {
            Operators op = new Operators();
            op.Add(10, 5);
            op.Subtract(10, 5);
            op.Multiply(10, 5);
            op.Divide(10, 5);
        }
    }








    //// ------Task 2------ 

    //// Class that performs null-related operations
    //public class NullOperations
    //{
    //    public void PerformNullChecks()
    //    {
    //        // Declare a string variable and assign null
    //        string username = null;

    //        // Using Ternary Operator (? :)
    //        Console.WriteLine(username == null ? "Username is not available" : username);

    //        // Using Null-Coalescing Operator (??)
    //        Console.WriteLine(username ?? "Username is not available");

    //        // Using Null-Coalescing Assignment Operator (??=)
    //        username ??= "DefaultUser";

    //        // Print updated value
    //        Console.WriteLine("Updated Username: " + username);
    //    }
    //}

    //// Main Program
    //internal class Program
    //{
    //    static void Main()
    //    {
    //        // Create object of NullOperations
    //        NullOperations nullOps = new NullOperations();

    //        // Call the method
    //        nullOps.PerformNullChecks();
    //    }
    //}









    //// ------Task 3------ 

    //internal class Program
    //{
    //    static void Main()
    //    {
    //        Console.Write("Enter your age: ");
    //        int age = Convert.ToInt32(Console.ReadLine());

    //        if (age < 13)
    //        {
    //            Console.WriteLine("Child");
    //        }
    //        else if (age >= 13 && age <= 19)
    //        {
    //            Console.WriteLine("Teenager");
    //        }
    //        else if (age >= 20 && age <= 59)
    //        {
    //            Console.WriteLine("Adult");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Senior Citizen");
    //        }
    //    }
    //}








    //// ------Task 4------ 
    //internal class Program
    //{
    //    static void Main()
    //    {
    //        Console.Write("Enter a number (1-7): ");
    //        int dayNumber = Convert.ToInt32(Console.ReadLine());

    //        switch (dayNumber)
    //        {
    //            case 1:
    //                Console.WriteLine("Sunday");
    //                break;
    //            case 2:
    //                Console.WriteLine("Monday");
    //                break;
    //            case 3:
    //                Console.WriteLine("Tuesday");
    //                break;
    //            case 4:
    //                Console.WriteLine("Wednesday");
    //                break;
    //            case 5:
    //                Console.WriteLine("Thursday");
    //                break;
    //            case 6:
    //                Console.WriteLine("Friday");
    //                break;
    //            case 7:
    //                Console.WriteLine("Saturday");
    //                break;
    //            default:
    //                Console.WriteLine("Invalid number! Please enter a number between 1 and 7.");
    //                break;
    //        }
    //    }
    //}








    //// ------Task 5------ 
    //internal class Program
    //{
    //    static void Main()
    //    {
    //        // --- Task 1: Sum from 1 to N using for loop ---
    //        Console.Write("Enter a number (N): ");
    //        int N = Convert.ToInt32(Console.ReadLine());
    //        int sum = 0;

    //        for (int i = 1; i <= N; i++)
    //        {
    //            sum += i;
    //        }

    //        Console.WriteLine("Sum from 1 to " + N + " is: " + sum);
    //        Console.WriteLine("-----------------------------------");

    //        // --- Task 2: Print numbers 1 to 20 using while loop ---
    //        // Skip multiples of 4 and stop when number is 15
    //        int num = 1;
    //        Console.WriteLine("Numbers from 1 to 20 (skip multiples of 4, stop at 15):");

    //        while (num <= 20)
    //        {
    //            if (num == 15)
    //                break; // stop the loop when number is 15

    //            if (num % 4 == 0)
    //            {
    //                num++;
    //                continue; // skip multiples of 4
    //            }

    //            Console.WriteLine(num);
    //            num++;
    //        }
    //        Console.WriteLine("-----------------------------------");

    //        // --- Task 3: Sum of all elements in an array using foreach loop ---
    //        int[] numbers = { 2, 4, 6, 8, 10 };
    //        int total = 0;

    //        foreach (int value in numbers)
    //        {
    //            total += value;
    //        }

    //        Console.WriteLine("Sum of array elements: " + total);
    //    }
    //}








    //// ------Task 6------ 
    //internal class Program
    //{
    //    static void Main()
    //    {
    //        // ----------- Task 1: Exception Handling for Number Input -----------
    //        try
    //        {
    //            Console.Write("Enter a number: ");
    //            int number = Convert.ToInt32(Console.ReadLine());
    //            Console.WriteLine("You entered: " + number);
    //        }
    //        catch (FormatException)
    //        {
    //            Console.WriteLine("Invalid number format");
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Program Executed");
    //        }

    //        Console.WriteLine("-----------------------------------");

    //        // ----------- Task 2: Password Validation with Throw -----------
    //        try
    //        {
    //            Console.Write("Enter a password: ");
    //            string password = Console.ReadLine();

    //            if (password.Length < 6)
    //            {
    //                throw new Exception("Password must be at least 6 characters.");
    //            }

    //            Console.WriteLine("Password satisfied the requirement");
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //    }
    //}

}
