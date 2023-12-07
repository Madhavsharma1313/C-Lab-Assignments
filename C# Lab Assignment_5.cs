using System;

C# Lab Assignment_5
1. Create a C# program that intentionally throws a DivideByZeroException when dividing by zero. Catch the exception and handle it gracefully.
using System;

class Program
{
    static void Main()
    {
        try
        {
            // Intentionally divide by zero to throw DivideByZeroException
            int result = DivideByZeroOperation(10, 0);
            Console.WriteLine($"Result: {result}"); // This line won't be reached
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            // Handle the exception gracefully, log, or perform other actions as needed
        }
    }

    static int DivideByZeroOperation(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return numerator / denominator;
    }
}
2.Write a program that attempts to access an array element at an index that is out of bounds. Use a try-catch block to handle the IndexOutOfRangeException.
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        try
        {
            // Attempt to access an array element at an out-of-bounds index
            int element = GetArrayElement(numbers, 10);
            Console.WriteLine($"Array element: {element}"); // This line won't be reached
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            // Handle the exception gracefully, log, or perform other actions as needed
        }
    }

    static int GetArrayElement(int[] array, int index)
    {
        if (index < 0 || index >= array.Length)
        {
            throw new IndexOutOfRangeException($"Index {index} is out of bounds.");
        }

        return array[index];
    }
}
3.Create a C# program that uses a try-catch block to handle an exception when converting a string to an integer using int.Parse(). Handle the FormatException that may occur.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string userInput = Console.ReadLine();

        try
        {
            // Attempt to convert the string to an integer
            int number = ConvertStringToInt(userInput);
            Console.WriteLine($"Converted number: {number}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            // Handle the exception gracefully, log, or perform other actions as needed
        }
    }

    static int ConvertStringToInt(string input)
    {
        // Attempt to convert the string to an integer
        return int.Parse(input);
    }
}
4.Implement a C# program that uses a custom exception class. Create a custom exception and throw it in your code when a specific condition is met. 
using System;

// Custom exception class
public class CustomException : Exception
{
    public CustomException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        try
        {
            // Simulate a condition where the custom exception should be thrown
            int userInput = GetUserInput();

            if (userInput < 0)
            {
                // Throw the custom exception if the input is negative
                throw new CustomException("Negative input is not allowed.");
            }

            Console.WriteLine($"User input: {userInput}");
        }
        catch (CustomException ex)
        {
            Console.WriteLine($"Custom Exception: {ex.Message}");
            // Handle the custom exception gracefully, log, or perform other actions as needed
        }
    }

    static int GetUserInput()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        // Attempt to parse the user input to an integer
        if (int.TryParse(input, out int result))
        {
            return result;
        }
        else
        {
            // If parsing fails, throw a custom exception
            throw new CustomException("Invalid input. Please enter a valid number.");
        }
    }
}
5.Build a C# program that demonstrates the use of multiple catch blocks for different exception types. Handle exceptions such as IndexOutOfRangeException, FormatException, and InvalidOperationException.
using System;

class Program
{
    static void Main()
    {
        try
        {
            // Simulate different scenarios that may throw exceptions
            int[] numbers = { 1, 2, 3, 4, 5 };
            int result = DivideByZeroOperation(10, 0);
            int arrayElement = GetArrayElement(numbers, 10);
            int parsedNumber = ConvertStringToInt("abc");

            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Array element: {arrayElement}");
            Console.WriteLine($"Parsed number: {parsedNumber}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"DivideByZeroException: {ex.Message}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"IndexOutOfRangeException: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"FormatException: {ex.Message}");
        }
        catch (Exception ex)
        {
            // Generic catch block for other types of exceptions
            Console.WriteLine($"Exception: {ex.Message}");
        }
    }

    static int DivideByZeroOperation(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return numerator / denominator;
    }

    static int GetArrayElement(int[] array, int index)
    {
        if (index < 0 || index >= array.Length)
        {
            throw new IndexOutOfRangeException($"Index {index} is out of bounds.");
        }

        return array[index];
    }

    static int ConvertStringToInt(string input)
    {
        if (int.TryParse(input, out int result))
        {
            return result;
        }
        else
        {
            throw new FormatException("Invalid input. Please enter a valid number.");
        }
    }
}
6.Create a C# program that includes nested try-catch blocks. Throw an exception in an inner block and catch it in the outer block. Explain the flow of execution.
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Outer try block - Start");

            // Outer try block
            try
            {
                Console.WriteLine("Inner try block - Start");

                // Simulate an exception in the inner try block
                ThrowInnerException();

                Console.WriteLine("Inner try block - End");
            }
            catch (Exception innerException)
            {
                Console.WriteLine($"Caught inner exception: {innerException.Message}");
                // Handle the inner exception or perform other actions as needed
            }

            Console.WriteLine("Outer try block - End");
        }
        catch (Exception outerException)
        {
            Console.WriteLine($"Caught outer exception: {outerException.Message}");
            // Handle the outer exception or perform other actions as needed
        }
    }

    static void ThrowInnerException()
    {
        // Simulate an exception in the inner method
        throw new InvalidOperationException("Something went wrong in the inner block.");
    }
}
7.Implement a program that divides two numbers entered by the user. Handle exceptions like division by zero and invalid input. Continue to prompt the user for valid input until a valid division is performed.
using System;

class Program
{
    static void Main()
    {
        bool validInput = false;

        do
        {
            try
            {
                // Prompt the user for two numbers
                Console.Write("Enter the numerator: ");
                int numerator = int.Parse(Console.ReadLine());

                Console.Write("Enter the denominator: ");
                int denominator = int.Parse(Console.ReadLine());

                // Perform the division
                double result = DivideNumbers(numerator, denominator);
                Console.WriteLine($"Result of {numerator} / {denominator} = {result}");

                // If no exceptions are thrown, set validInput to true to exit the loop
                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed. Please enter a non-zero denominator.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        } while (!validInput);
    }

    static double DivideNumbers(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return (double)numerator / denominator;
    }
}
8.Develop a C# program that demonstrates how to use the throw statement to rethrow an exception. Catch the rethrown exception and handle it appropriately.
using System;

class Program
{
    static void Main()
    {
        try
        {
            // Simulate an initial exception
            ThrowOriginalException();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Caught original exception: {ex.Message}");

            // Rethrow the exception
            Console.WriteLine("Rethrowing the exception...");
            RethrowException(ex);
        }
    }

    static void ThrowOriginalException()
    {
        // Simulate an initial exception
        throw new InvalidOperationException("Original exception occurred.");
    }

    static void RethrowException(Exception originalException)
    {
        try
        {
            // Attempt some operation that may throw a new exception
            int result = DivideByZeroOperation(10, 0);
        }
        catch (Exception newException)
        {
            Console.WriteLine($"Caught rethrown exception: {newException.Message}");

            // Handle the rethrown exception appropriately
            // You can perform additional logging or take other actions here
        }

        // You can choose to rethrow the original exception or not based on your needs
        throw originalException;
    }

    static int DivideByZeroOperation(int numerator, int denominator)
    {
        // Attempt to perform a division that may throw an exception
        return numerator / denominator;
    }
}
9.Develop a program that simulates a simple calculator with basic arithmetic operations (addition, subtraction, multiplication, and division). Use exception handling to catch and handle various type of exceptions that may occur.
using System;

class Calculator
{
    static void Main()
    {
        try
        {
            // Get user input for numbers and operation
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the operation (+, -, *, /): ");
            char operation = char.Parse(Console.ReadLine());

            // Perform the selected operation
            double result = PerformOperation(num1, num2, operation);

            // Display the result
            Console.WriteLine($"Result: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter valid numbers and operation.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero. Please enter a non-zero second number.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }

    static double PerformOperation(double num1, double num2, char operation)
    {
        switch (operation)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                if (num2 == 0)
                {
                    throw new DivideByZeroException();
                }
                return num1 / num2;
            default:
                throw new InvalidOperationException("Invalid operation. Please enter +, -, *, or /.");
        }
    }
}
10.Scenario
You are developing a simple e-commerce application in C#. One of the features is a shopping 
cart that allows users to add items to their cart. The cart is represented as an array of integers,
where each integer corresponds to an item's price. Users can input the price of an item they 
want to add to the cart. You want to handle exceptions gracefully to ensure a smooth user 
experience. If the user enters an invalid price, your code should catch and handle the exception 
appropriately.
Question:
Write a C# program that simulates adding items to a shopping cart. The program should take 
user input for the price of items and store them in an array. Implement exception handling with 
multiple catch blocks to handle various scenarios. Specifically, you should handle the following 
exceptions:
• If the user enters a negative price, catch and handle the exception as a "NegativePriceException." Display a message indicating that the price entered is invalid.
• If the user enters a non-numeric value (e.g., a string), catch and handle the exception as a "FormatException." Display a message indicating that the input is not a valid price.
• If the user enters a price that exceeds a predefined maximum value (e.g., 10000), catch and handle the exception as a "PriceTooHighException." Display a message indicating that the price entered is too high.
using System;

public class NegativePriceException : Exception
{
    public NegativePriceException(string message) : base(message)
    {
    }
}

public class PriceTooHighException : Exception
{
    public PriceTooHighException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        const double MaxPrice = 10000;
        int[] shoppingCart = new int[5]; // Assuming a maximum of 5 items in the cart

        for (int i = 0; i < shoppingCart.Length; i++)
        {
            try
            {
                Console.Write($"Enter the price of item {i + 1}: ");
                double price = GetItemPrice();

                // Check for negative price
                if (price < 0)
                {
                    throw new NegativePriceException("Negative prices are not allowed.");
                }

                // Check for price too high
                if (price > MaxPrice)
                {
                    throw new PriceTooHighException($"Price exceeds the maximum allowed value of {MaxPrice}.");
                }

                // If all checks pass, add the price to the shopping cart
                shoppingCart[i] = (int)price;
            }
            catch (NegativePriceException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                i--; // Prompt the user for the same item again
            }
            catch (PriceTooHighException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                i--; // Prompt the user for the same item again
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid numeric price.");
                i--; // Prompt the user for the same item again
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                i--; // Prompt the user for the same item again
            }
        }

        // Display the contents of the shopping cart
        Console.WriteLine("\nShopping Cart Contents:");
        for (int i = 0; i < shoppingCart.Length; i++)
        {
            Console.WriteLine($"Item {i + 1}: {shoppingCart[i]}");
        }
    }

    static double GetItemPrice()
    {
        string input = Console.ReadLine();
        if (!double.TryParse(input, out double price))
        {
            throw new FormatException();
        }
        return price;
    }
}
