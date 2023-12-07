using System.Collections.Generic;
using System;

C# Lab Assignment_4
1. Create a class representing a bank account with a balance property. Implement a property validation that prevents the balance from going negative.
using System;

public class BankAccount
{
    // Private backing field for balance
    private decimal _balance;

    // Public property with validation
    public decimal Balance
    {
        get { return _balance; }
        set
        {
            // Validation: Prevent balance from going negative
            if (value < 0)
            {
                Console.WriteLine("Error: Balance cannot be set to a negative value.");
            }
            else
            {
                _balance = value;
            }
        }
    }

    // Constructor to initialize balance
    public BankAccount(decimal initialBalance)
    {
        // Validation during initialization
        Balance = initialBalance;
    }

    // Method to display account information
    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Balance: {Balance:C}");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of BankAccount
        BankAccount myAccount = new BankAccount(1000.0m);

        // Display initial account information
        Console.WriteLine("Initial Account Information:");
        myAccount.DisplayAccountInfo();

        // Attempt to set a negative balance
        Console.WriteLine("\nAttempting to set a negative balance:");
        myAccount.Balance = -500.0m;

        // Display updated account information
        Console.WriteLine("\nUpdated Account Information:");
        myAccount.DisplayAccountInfo();
    }
}
2.Write a class representing a car with properties for make, model, and year. Implement a property that returns the full car name (e.g., "Toyota Camry 2022").
using System;

public class Car
{
    // Properties for make, model, and year
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    // Property to return the full car name
    public string FullCarName
    {
        get { return $"{Make} {Model} {Year}"; }
    }

    // Constructor to initialize make, model, and year
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of Car
        Car myCar = new Car("Toyota", "Camry", 2022);

        // Display the full car name using the property
        Console.WriteLine($"Full Car Name: {myCar.FullCarName}");
    }
}
3.Create a class representing a person with properties for first name and last name. Implement a property that returns the full name in uppercase.
using System;

public class Person
{
    // Properties for first name and last name
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Property to return the full name in uppercase
    public string FullUpperCaseName
    {
        get { return $"{FirstName} {LastName}".ToUpper(); }
    }

    // Constructor to initialize first name and last name
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of Person
        Person myPerson = new Person("John", "Doe");

        // Display the full name in uppercase using the property
        Console.WriteLine($"Full Name in Uppercase: {myPerson.FullUpperCaseName}");
    }
}
4.Implement a property for a class representing a temperature in Celsius that converts the temperature to Fahrenheit when accessed.
using System;

public class Temperature
{
    // Property for temperature in Celsius
    private double celsius;

    public double Celsius
    {
        get { return celsius; }
        set { celsius = value; }
    }

    // Property for temperature in Fahrenheit (converted from Celsius)
    public double Fahrenheit
    {
        get { return CelsiusToFarhenheit(Celsius); }
    }

    // Constructor to initialize temperature in Celsius
    public Temperature(double celsius)
    {
        Celsius = celsius;
    }

    // Method to convert Celsius to Fahrenheit
    private double CelsiusToFarhenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of Temperature
        Temperature myTemperature = new Temperature(25.0);

        // Display the temperature in Celsius and Fahrenheit
        Console.WriteLine($"Temperature in Celsius: {myTemperature.Celsius}°C");
        Console.WriteLine($"Temperature in Fahrenheit: {myTemperature.Fahrenheit}°F");
    }
}
5.Build a class representing a custom list and implement an indexer to access elements by index.
using System;

public class CustomList<T>
{
    // Internal array to store elements
    private T[] elements;

    // Constructor to initialize the custom list with a specified capacity
    public CustomList(int capacity)
    {
        elements = new T[capacity];
    }

    // Indexer to access elements by index
    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= elements.Length)
            {
                throw new IndexOutOfRangeException($"Index {index} is out of range.");
            }
            return elements[index];
        }
        set
        {
            if (index < 0 || index >= elements.Length)
            {
                throw new IndexOutOfRangeException($"Index {index} is out of range.");
            }
            elements[index] = value;
        }
    }

    // Method to display elements in the custom list
    public void DisplayElements()
    {
        Console.WriteLine("Elements in the custom list:");
        foreach (var element in elements)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of CustomList with a capacity of 5
        CustomList<int> myList = new CustomList<int>(5);

        // Set elements using the indexer
        myList[0] = 10;
        myList[1] = 20;
        myList[2] = 30;
        myList[3] = 40;
        myList[4] = 50;

        // Display elements using the indexer
        myList.DisplayElements();

        // Access elements using the indexer
        Console.WriteLine($"Element at index 2: {myList[2]}");
    }
}
6.How can you use an indexer to create a simple stack data structure in C#?
using System;

public class SimpleStack<T>
{
    private T[] stackArray;
    private int top; // Index of the top element in the stack

    // Constructor to initialize the stack with a specified capacity
    public SimpleStack(int capacity)
    {
        stackArray = new T[capacity];
        top = -1; // Initialize top to -1 for an empty stack
    }

    // Indexer to access elements in the stack
    public T this[int index]
    {
        get
        {
            if (index < 0 || index > top)
            {
                throw new IndexOutOfRangeException($"Index {index} is out of range.");
            }
            return stackArray[index];
        }
    }

    // Method to push an element onto the stack
    public void Push(T item)
    {
        if (top == stackArray.Length - 1)
        {
            Console.WriteLine("Stack overflow. Cannot push more elements.");
        }
        else
        {
            top++;
            stackArray[top] = item;
            Console.WriteLine($"Pushed element: {item}");
        }
    }

    // Method to pop an element from the stack
    public T Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack underflow. Cannot pop from an empty stack.");
            return default(T);
        }
        else
        {
            T poppedElement = stackArray[top];
            top--;
            Console.WriteLine($"Popped element: {poppedElement}");
            return poppedElement;
        }
    }

    // Method to display elements in the stack
    public void DisplayStack()
    {
        Console.WriteLine("Elements in the stack:");
        for (int i = 0; i <= top; i++)
        {
            Console.Write($"{stackArray[i]} ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of SimpleStack with a capacity of 5
        SimpleStack<int> myStack = new SimpleStack<int>(5);

        // Push elements onto the stack
        myStack.Push(10);
        myStack.Push(20);
        myStack.Push(30);

        // Display elements using the indexer
        Console.WriteLine($"Element at index 1: {myStack[1]}");

        // Pop elements from the stack
        myStack.Pop();
        myStack.Pop();

        // Display remaining elements in the stack
        myStack.DisplayStack();
    }
}
7.Implement an indexer in a class representing a bookshelf that allows you to access books by title.
using System;
using System.Collections.Generic;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

public class Bookshelf
{
    private List<Book> books;

    public Bookshelf()
    {
        books = new List<Book>();
    }

    // Indexer to access books by title
    public Book this[string title]
    {
        get
        {
            return books.Find(book => book.Title == title);
        }
    }

    // Method to add a book to the bookshelf
    public void AddBook(Book book)
    {
        books.Add(book);
    }

    // Method to display all books on the bookshelf
    public void DisplayBooks()
    {
        Console.WriteLine("Books on the bookshelf:");
        foreach (var book in books)
        {
            Console.WriteLine($"{book.Title} by {book.Author}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of Bookshelf
        Bookshelf myBookshelf = new Bookshelf();

        // Add books to the bookshelf
        myBookshelf.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald"));
        myBookshelf.AddBook(new Book("To Kill a Mockingbird", "Harper Lee"));
        myBookshelf.AddBook(new Book("1984", "George Orwell"));

        // Display all books on the bookshelf
        myBookshelf.DisplayBooks();

        // Access a book by title using the indexer
        string titleToFind = "To Kill a Mockingbird";
        Book foundBook = myBookshelf[titleToFind];

        if (foundBook != null)
        {
            Console.WriteLine($"\nBook found: {foundBook.Title} by {foundBook.Author}");
        }
        else
        {
            Console.WriteLine($"\nBook with title '{titleToFind}' not found.");
        }
    }
}
8.Create an enum representing the seasons and write a switch statement that prints a message based on the current season.
using System;

// Enum representing the seasons
public enum Seasons
{
    Spring,
    Summer,
    Autumn,
    Winter
}

class Program
{
    static void Main()
    {
        // Set the current season (you can get this value from your application logic)
        Seasons currentSeason = Seasons.Summer;

        // Switch statement to print a message based on the current season
        switch (currentSeason)
        {
            case Seasons.Spring:
                Console.WriteLine("It's spring! Flowers are blooming.");
                break;
            case Seasons.Summer:
                Console.WriteLine("It's summer! Enjoy the warm weather.");
                break;
            case Seasons.Autumn:
                Console.WriteLine("It's autumn! Leaves are changing colors.");
                break;
            case Seasons.Winter:
                Console.WriteLine("It's winter! Bundle up, it's cold outside.");
                break;
            default:
                Console.WriteLine("Invalid season.");
                break;
        }
    }
}
9.Implement an enum to represent different geometric shapes (e.g., Circle, Square, Triangle) and use it to calculate the area of a specific shape.
using System;

// Enum representing different geometric shapes
public enum ShapeType
{
    Circle,
    Square,
    Triangle
}

// Class representing a geometric shape
public class Shape
{
    // Method to calculate the area based on the shape type and dimensions
    public double CalculateArea(ShapeType shapeType, double[] dimensions)
    {
        switch (shapeType)
        {
            case ShapeType.Circle:
                // Area of a circle: π * r^2
                double radius = dimensions.Length > 0 ? dimensions[0] : 0.0;
                return Math.PI * Math.Pow(radius, 2);

            case ShapeType.Square:
                // Area of a square: side^2
                double side = dimensions.Length > 0 ? dimensions[0] : 0.0;
                return Math.Pow(side, 2);

            case ShapeType.Triangle:
                // Area of a triangle: 0.5 * base * height
                double baseLength = dimensions.Length > 0 ? dimensions[0] : 0.0;
                double height = dimensions.Length > 1 ? dimensions[1] : 0.0;
                return 0.5 * baseLength * height;

            default:
                Console.WriteLine("Invalid shape type.");
                return 0.0;
        }
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of Shape
        Shape myShape = new Shape();

        // Define the shape type and dimensions
        ShapeType shapeType = ShapeType.Circle;
        double[] dimensions = { 5.0 }; // For a circle, provide the radius

        // Calculate and display the area
        double area = myShape.CalculateArea(shapeType, dimensions);
        Console.WriteLine($"Area of the {shapeType}: {area} square units");
    }
}
10.Create an enum with flags to represent the permission levels (Read, Write, Execute) of a file, and demonstrate how to combine these permissions for a user.
using System;

// Enum with flags representing file permissions
[Flags]
public enum FilePermission
{
    None = 0,
    Read = 1 << 0,    // 1
    Write = 1 << 1,   // 2
    Execute = 1 << 2  // 4
}

class Program
{
    static void Main()
    {
        // Combine file permissions for a user
        FilePermission userPermissions = FilePermission.Read | FilePermission.Write;

        // Check if a specific permission is set
        if ((userPermissions & FilePermission.Read) == FilePermission.Read)
        {
            Console.WriteLine("User has Read permission.");
        }

        // Check if a combination of permissions is set
        if ((userPermissions & (FilePermission.Write | FilePermission.Execute)) == (FilePermission.Write | FilePermission.Execute))
        {
            Console.WriteLine("User has both Write and Execute permissions.");
        }
    }
}

