namespace Workshop2
{
    //        // ---- Task 1 -----
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declare and initialize variables
            string userName = "Aagam Parajuli";
            int luckyNumber = 7;

            // Use string interpolation to display the message
            Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");

        }
    }





    //        // ---- Task 2 -----
    //class Circle
    //{
    //    // Declare constant variable
    //    public const double PI = 3.14;

    //    // Method to calculate area
    //    public static double CalculateArea(double radius)
    //    {
    //        return PI * radius * radius;
    //    }

    //    // Method to calculate perimeter (circumference)
    //    public static double CalculatePerimeter(double radius)
    //    {
    //        return 2 * PI * radius;
    //    }
    //}

    //// Program class
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Try to modify the value of PI
    //        // Circle.PI = 3.14159;   // ❌ This will cause a compilation error

    //        // Error explanation:
    //        // The left-hand side of an assignment must be a variable, property, or indexer.
    //        // Since 'PI' is declared as a constant, its value cannot be changed once defined.

    //        double radius = 5;
    //        Console.WriteLine($"For radius = {radius}");
    //        Console.WriteLine($"Area of circle = {Circle.CalculateArea(radius)}");
    //        Console.WriteLine($"Perimeter of circle = {Circle.CalculatePerimeter(radius)}");
    //    }
    //}





    //         // ---- Task 3 -----
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Declare and initialize variables of different types
    //        byte byteValue = 10;
    //        short shortValue = 200;
    //        int intValue = 1000;
    //        long longValue = 50000L;
    //        float floatValue = 3.5f;
    //        double doubleValue = 7.89;
    //        decimal decimalValue = 123.456m;
    //        char charValue = 'A';
    //        bool boolValue = true;

    //        // Type conversion
    //        string intToString = intValue.ToString();     // Convert int to string
    //        string strNumber = "3.14";
    //        double strToDouble = Convert.ToDouble(strNumber);  // Convert string to double

    //        // Print all variables with labels
    //        Console.WriteLine("Data Types and Values:");
    //        Console.WriteLine($"byte: {byteValue}");
    //        Console.WriteLine($"short: {shortValue}");
    //        Console.WriteLine($"int: {intValue}");
    //        Console.WriteLine($"long: {longValue}");
    //        Console.WriteLine($"float: {floatValue}");
    //        Console.WriteLine($"double: {doubleValue}");
    //        Console.WriteLine($"decimal: {decimalValue}");
    //        Console.WriteLine($"char: {charValue}");
    //        Console.WriteLine($"bool: {boolValue}");
    //        Console.WriteLine();
    //        Console.WriteLine($"Converted int to string: {intToString}");
    //        Console.WriteLine($"Converted string \"{strNumber}\" to double: {strToDouble}");
    //    }
    //}




    //         //---- Task 4 -----
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Create an integer array with 5 favorite numbers
    //        int[] favoriteNumbers = { 9, 3, 7, 1, 5 };

    //        // Sort the array in ascending order
    //        Array.Sort(favoriteNumbers);
    //        Console.WriteLine("Array after sorting in ascending order:");
    //        foreach (int num in favoriteNumbers)
    //        {
    //            Console.Write(num + " ");
    //        }

    //        Console.WriteLine("\n");

    //        // Reverse the sorted array (to make it descending)
    //        Array.Reverse(favoriteNumbers);
    //        Console.WriteLine("Array after reversing (descending order):");
    //        for (int i = 0; i < favoriteNumbers.Length; i++)
    //        {
    //            Console.Write(favoriteNumbers[i] + " ");
    //        }

    //        Console.WriteLine("\n");

    //        // Find the position of a specific number
    //        int searchNumber = 7;
    //        int position = Array.IndexOf(favoriteNumbers, searchNumber);

    //        if (position >= 0)
    //        {
    //            Console.WriteLine($"Number {searchNumber} found at index position: {position}");
    //        }
    //        else
    //        {
    //            Console.WriteLine($"Number {searchNumber} not found in the array.");
    //        }
    //    }
    //}





    //         //---- Task 5 -----
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Create a DateTime variable for your birthdate
    //        DateTime birthDate = new DateTime(2003, 5, 12); // Example: 12 May 2003

    //        // Create another DateTime variable for the current date and time
    //        DateTime currentDate = DateTime.Now;

    //        // Calculate age using TimeSpan
    //        TimeSpan ageSpan = currentDate - birthDate;

    //        // Convert total days to years (approximation)
    //        int ageInYears = (int)(ageSpan.TotalDays / 365.25);

    //        // Display the results
    //        Console.WriteLine("Birthdate: " + birthDate.ToShortDateString());
    //        Console.WriteLine("Current Date: " + currentDate.ToShortDateString());
    //        Console.WriteLine("Age in Years: " + ageInYears);

    //        // Add 10 days to birthdate and display the new date
    //        DateTime newDate = birthDate.AddDays(10);
    //        Console.WriteLine("Birthdate after adding 10 days: " + newDate.ToShortDateString());
    //    }
    //}






    //         //---- Task 6 -----
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Create a List of favorite fruits
    //        List<string> fruits = new List<string> { "Mango", "Apple", "Banana" };

    //        // Add a new fruit to the list
    //        fruits.Add("Orange");

    //        // Remove one fruit from the list
    //        fruits.Remove("Banana");

    //        // Print all fruits using foreach loop
    //        Console.WriteLine("Fruits in the list:");
    //        foreach (string fruit in fruits)
    //        {
    //            Console.WriteLine(fruit);
    //        }

    //        Console.WriteLine();

    //        // Create a Dictionary with fruit IDs and names
    //        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
    //        {
    //            {1, "Mango"},
    //            {2, "Apple"},
    //            {3, "Orange"}
    //        };

    //        // Add a new fruit entry to the dictionary
    //        fruitDictionary.Add(4, "Pineapple");

    //        // Print all key-value pairs
    //        Console.WriteLine("Fruits in the dictionary:");
    //        foreach (KeyValuePair<int, string> pair in fruitDictionary)
    //        {
    //            Console.WriteLine($"ID: {pair.Key}, Fruit: {pair.Value}");
    //        }
    //    }
    //}


}
