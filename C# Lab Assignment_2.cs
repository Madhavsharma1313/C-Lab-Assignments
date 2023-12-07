using System;

C# Lab Assignment_2
Instance Class
1. Create a class called Employee with properties for name, age, and salary. Implement a method to display employee details.
using System;

class Employee
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    // Constructor
    public Employee(string name, int age, double salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }

    // Method to display employee details
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Salary: {Salary:C}"); // Display salary as currency
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Employee class
        Employee employee1 = new Employee("John Doe", 30, 50000.0);

        // Call the DisplayDetails method to display employee details
        Console.WriteLine("Employee Details:");
        employee1.DisplayDetails();
    }
}
2.Create a class called BankAccount with properties for account number, account holder name, and balance. Implement methods for deposit, withdrawal, and displaying the account details.
using System;

class BankAccount
{
    // Properties
    public string AccountNumber { get; private set; }
    public string AccountHolderName { get; set; }
    public double Balance { get; private set; }

    // Constructor
    public BankAccount(string accountNumber, string accountHolderName, double initialBalance)
    {
        AccountNumber = accountNumber;
        AccountHolderName = accountHolderName;
        Balance = initialBalance;
    }

    // Method to deposit money
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: {amount:C}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount. Amount should be greater than 0.");
        }
    }

    // Method to withdraw money
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn: {amount:C}");
        }
        else if (amount <= 0)
        {
            Console.WriteLine("Invalid withdrawal amount. Amount should be greater than 0.");
        }
        else
        {
            Console.WriteLine("Insufficient funds for withdrawal.");
        }
    }

    // Method to display account details
    public void DisplayAccountDetails()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Account Holder Name: {AccountHolderName}");
        Console.WriteLine($"Balance: {Balance:C}");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the BankAccount class
        BankAccount account1 = new BankAccount("123456789", "John Doe", 1000.0);

        // Deposit money
        account1.Deposit(500.0);

        // Withdraw money
        account1.Withdraw(200.0);

        // Display account details
        Console.WriteLine("Account Details:");
        account1.DisplayAccountDetails();
    }
}
Static Class:
3.Create a static utility class named MathHelper with a static method CalculateAverage that takes an array of integers as input and returns their average.
using System;

public static class MathHelper
{
    // Static method to calculate the average of an array of integers
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty.");
        }

        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        return (double)sum / numbers.Length;
    }
}

class Program
{
    static void Main()
    {
        // Example array of integers
        int[] numbers = { 5, 10, 15, 20, 25 };

        // Call the static method to calculate the average
        double average = MathHelper.CalculateAverage(numbers);

        // Display the result
        Console.WriteLine($"The average of the numbers is: {average:F2}");
    }
}
4.Implement a static logger class called Logger that has a method LogMessage for writing messages on console. Demonstrate its usage in a simple console application.
using System;

public static class Logger
{
    // Static method to log messages on the console
    public static void LogMessage(string message)
    {
        Console.WriteLine($"[Log] {DateTime.Now:yyyy-MM-dd HH:mm:ss}: {message}");
    }
}

class Program
{
    static void Main()
    {
        // Demonstrate usage of the Logger class
        Logger.LogMessage("Application started.");

        // Perform some actions or operations

        Logger.LogMessage("Operation completed successfully.");

        // Simulate an error
        try
        {
            // Code that might throw an exception
            throw new Exception("Simulated error occurred.");
        }
        catch (Exception ex)
        {
            // Log the error message using the Logger class
            Logger.LogMessage($"Error: {ex.Message}");
        }

        Logger.LogMessage("Application finished.");
    }
}
Partial Class:
5.Define a partial class Person with one part containing properties like FirstName and LastName, and another part with methods like PrintFullName to display the full name. Implement these parts in separate files.
// File 1: PersonProperties.cs

public partial class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

// File 2: PersonMethods.cs

using System;

public partial class Person
{
    // Method to print the full name
    public void PrintFullName()
    {
        string fullName = $"{FirstName} {LastName}";
        Console.WriteLine($"Full Name: {fullName}");
    }
}

// File 3: Program.cs

class Program
{
    static void Main()
    {
        // Create an instance of the partial class Person
        Person person = new Person
        {
            FirstName = "John",
            LastName = "Doe"
        };

        // Call the PrintFullName method
        person.PrintFullName();
    }
}
6.Create a partial class Employee with properties representing employee details. In another part, implement methods for calculating salary based on different factors.
// File 1: EmployeeProperties.cs

public partial class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int EmployeeId { get; set; }
    public double BaseSalary { get; set; }
}

// File 2: EmployeeMethods.cs

using System;

public partial class Employee
{
    // Method to calculate salary based on experience
    public double CalculateSalaryBasedOnExperience(int yearsOfExperience)
    {
        // Basic salary plus additional bonus for experience
        double bonus = yearsOfExperience * 1000;
        return BaseSalary + bonus;
    }

    // Method to calculate salary based on performance
    public double CalculateSalaryBasedOnPerformance(string performanceRating)
    {
        // Assume "Excellent" rating gets a 10% bonus
        double bonusPercentage = 0.10;

        // Check performance rating and calculate bonus
        switch (performanceRating)
        {
            case "Excellent":
                return BaseSalary + (BaseSalary * bonusPercentage);
            default:
                return BaseSalary;
        }
    }

    // Method to display employee details
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"Employee ID: {EmployeeId}");
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Base Salary: {BaseSalary:C}");
    }
}

// File 3: Program.cs

class Program
{
    static void Main()
    {
        // Create an instance of the partial class Employee
        Employee employee = new Employee
        {
            EmployeeId = 1,
            FirstName = "John",
            LastName = "Doe",
            BaseSalary = 50000.0
        };

        // Calculate salary based on experience and display details
        double experienceBasedSalary = employee.CalculateSalaryBasedOnExperience(5);
        Console.WriteLine($"Salary based on experience: {experienceBasedSalary:C}");

        // Calculate salary based on performance and display details
        double performanceBasedSalary = employee.CalculateSalaryBasedOnPerformance("Excellent");
        Console.WriteLine($"Salary based on performance: {performanceBasedSalary:C}");

        // Display employee details
        Console.WriteLine("\nEmployee Details:");
        employee.DisplayEmployeeDetails();
    }
}
Abstract Class:
7.Define an abstract base class Shape with an abstract method CalculateArea.Derive classes like Circle and Rectangle from Shape and implement the area calculation methods for each.
using System;

// Abstract base class
public abstract class Shape
{
    // Abstract method to calculate area
    public abstract double CalculateArea();
}

// Derived class Circle
public class Circle : Shape
{
    public double Radius { get; set; }

    // Constructor
    public Circle(double radius)
    {
        Radius = radius;
    }

    // Implementing the abstract method to calculate area for Circle
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

// Derived class Rectangle
public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    // Constructor
    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    // Implementing the abstract method to calculate area for Rectangle
    public override double CalculateArea()
    {
        return Length * Width;
    }
}

class Program
{
    static void Main()
    {
        // Create instances of Circle and Rectangle
        Circle circle = new Circle(5.0);
        Rectangle rectangle = new Rectangle(4.0, 6.0);

        // Calculate and display areas
        Console.WriteLine($"Area of Circle with radius {circle.Radius}: {circle.CalculateArea():F2}");
        Console.WriteLine($"Area of Rectangle with length {rectangle.Length} and width {rectangle.Width}: {rectangle.CalculateArea():F2}");
    }
}
8.Design an abstract class Animal with properties like Name and Age. Derive classes like Dog and Cat from Animal with their unique methods.
using System;

// Abstract base class
public abstract class Animal
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Abstract method
    public abstract void MakeSound();
}

// Derived class Dog
public class Dog : Animal
{
    // Constructor
    public Dog(string name, int age) : base(name, age)
    {
    }

    // Implementing the abstract method for Dog
    public override void MakeSound()
    {
        Console.WriteLine("Woof! Woof!");
    }

    // Unique method for Dog
    public void Fetch()
    {
        Console.WriteLine($"{Name} is fetching the ball.");
    }
}

// Derived class Cat
public class Cat : Animal
{
    // Constructor
    public Cat(string name, int age) : base(name, age)
    {
    }

    // Implementing the abstract method for Cat
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }

    // Unique method for Cat
    public void Scratch()
    {
        Console.WriteLine($"{Name} is scratching.");
    }
}

class Program
{
    static void Main()
    {
        // Create instances of Dog and Cat
        Dog dog = new Dog("Buddy", 3);
        Cat cat = new Cat("Whiskers", 2);

        // Invoke methods
        Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}");
        dog.MakeSound();
        dog.Fetch();

        Console.WriteLine("\n");

        Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}");
        cat.MakeSound();
        cat.Scratch();
    }
}
Sealed Class:
9.Create a base class Vehicle with methods like StartEngine and StopEngine. Derive a class Car from Vehicle and seal it.Try to create a class that inherits from Car and observe the behavior.
using System;

// Base class
public class Vehicle
{
    // Method to start the engine
    public virtual void StartEngine()
    {
        Console.WriteLine("Engine started.");
    }

    // Method to stop the engine
    public virtual void StopEngine()
    {
        Console.WriteLine("Engine stopped.");
    }
}

// Derived and sealed class
public sealed class Car : Vehicle
{
    // Additional members or methods specific to Car can be added here
}

// Attempt to inherit from sealed class (this will result in a compilation error)
// Uncommenting the following code will result in a compilation error:
/*
public class SportsCar : Car
{
    // Additional members or methods specific to SportsCar can be added here
}
*/

class Program
{
    static void Main()
    {
        // Create an instance of the sealed class Car
        Car myCar = new Car();

        // Call methods on the Car instance
        myCar.StartEngine();
        myCar.StopEngine();
    }
}
10.Design a class BankAccount with properties like AccountNumber and Balance. Implement a sealed class SavingsAccount that extends BankAccount with methods for interest calculation.
using System;

// Base class
public class BankAccount
{
    // Properties
    public string AccountNumber { get; set; }
    public double Balance { get; set; }

    // Constructor
    public BankAccount(string accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }
}

// Sealed class extending BankAccount
public sealed class SavingsAccount : BankAccount
{
    // Constructor using base class constructor
    public SavingsAccount(string accountNumber, double balance) : base(accountNumber, balance)
    {
    }

    // Method to calculate and add interest
    public void AddInterest(double interestRate)
    {
        double interestAmount = Balance * (interestRate / 100);
        Balance += interestAmount;
        Console.WriteLine($"Interest of {interestAmount:C} added. New balance: {Balance:C}");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of SavingsAccount
        SavingsAccount savingsAccount = new SavingsAccount("SA123456", 5000.0);

        // Display initial balance
        Console.WriteLine($"Initial balance: {savingsAccount.Balance:C}");

        // Add interest
        savingsAccount.AddInterest(5.0);

        // Display updated balance after interest
        Console.WriteLine($"Final balance: {savingsAccount.Balance:C}");
    }
}

