                                           C# Lab Assignment_1
1. Write a C# program to find the sum of all elements in an integer array using a loop.
using System;
class Program
{
    static void Main()
    {
        // Example integer array
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Call the function to calculate the sum
        int sum = CalculateSum(numbers);

        // Display the result
        Console.WriteLine($"The sum of all elements in the array is: {sum}");
    }

    // Function to calculate the sum of elements in an array
    static int CalculateSum(int[] array)
    {
        int sum = 0;

        // Loop through each element in the array and add it to the sum
        foreach (int num in array)
        {
            sum += num;
        }

        return sum;
    }
}

2.Create a C# program that calculates the average of values in a floating-point array using a loop.
using System;

class Program
{
    static void Main()
    {
        // Example floating-point array
        float[] numbers = { 1.5f, 2.3f, 3.7f, 4.2f, 5.1f };

        // Call the function to calculate the average
        float average = CalculateAverage(numbers);

        // Display the result
        Console.WriteLine($"The average of values in the array is: {average}");
    }

    // Function to calculate the average of elements in an array
    static float CalculateAverage(float[] array)
    {
        float sum = 0;

        // Loop through each element in the array and add it to the sum
        foreach (float num in array)
        {
            sum += num;
        }

        // Calculate the average by dividing the sum by the number of elements
        float average = sum / array.Length;

        return average;
    }
}

3.Develop a C# program that finds the largest element in an integer array using a loop and if-else statements.
using System;

class Program
{
    static void Main()
    {
        // Example integer array
        int[] numbers = { 4, 8, 2, 10, 5 };

        // Call the function to find the largest element
        int largestElement = FindLargestElement(numbers);

        // Display the result
        Console.WriteLine($"The largest element in the array is: {largestElement}");
    }

    // Function to find the largest element in an array
    static int FindLargestElement(int[] array)
    {
        // Check if the array is empty
        if (array.Length == 0)
        {
            throw new ArgumentException("Array is empty");
        }

        // Initialize the largest element with the first element
        int largestElement = array[0];

        // Loop through each element in the array
        for (int i = 1; i < array.Length; i++)
        {
            // Compare the current element with the largestElement
            if (array[i] > largestElement)
            {
                // If the current element is larger, update the largestElement
                largestElement = array[i];
            }
        }

        return largestElement;
    }
}

4.Write a C# program that counts the number of even and odd elements in an integer array using a loop and if-else statements.
using System;

class Program
{
    static void Main()
    {
        // Example integer array
        int[] numbers = { 4, 8, 3, 10, 5 };

        // Call the function to count even and odd elements
        CountEvenOddElements(numbers, out int evenCount, out int oddCount);

        // Display the result
        Console.WriteLine($"Number of even elements: {evenCount}");
        Console.WriteLine($"Number of odd elements: {oddCount}");
    }

    // Function to count even and odd elements in an array
    static void CountEvenOddElements(int[] array, out int evenCount, out int oddCount)
    {
        // Initialize counters
        evenCount = 0;
        oddCount = 0;

        // Loop through each element in the array
        foreach (int num in array)
        {
            // Check if the current element is even or odd
            if (num % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }
    }
}

5.Implement a C# program that reverses the elements of an integer array using a loop.
using System;

class Program
{
    static void Main()
    {
        // Example integer array
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Call the function to reverse the array
        ReverseArray(numbers);

        // Display the reversed array
        Console.WriteLine("Reversed array:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }

    // Function to reverse the elements of an array
    static void ReverseArray(int[] array)
    {
        int length = array.Length;
        // Loop through the array up to its midpoint
        for (int i = 0; i < length / 2; i++)
        {
            // Swap elements symmetrically across the midpoint
            int temp = array[i];
            array[i] = array[length - i - 1];
            array[length - i - 1] = temp;
        }
    }
}
6.Create a C# program that multiplies each element in an integer array by a specified factor using a loop.
using System;

class Program
{
    static void Main()
    {
        // Example integer array
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Specify the multiplication factor
        int factor = 2;

        // Call the function to multiply the array elements by the factor
        MultiplyArrayByFactor(numbers, factor);

        // Display the modified array
        Console.WriteLine($"Array elements multiplied by {factor}:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }

    // Function to multiply each element in an array by a specified factor
    static void MultiplyArrayByFactor(int[] array, int factor)
    {
        // Loop through each element in the array
        for (int i = 0; i < array.Length; i++)
        {
            // Multiply the current element by the factor
            array[i] *= factor;
        }
    }
}
7.Write a C# program that searches for a specific value in an integer array using a loop and returns its index if found.
using System;

class Program
{
    static void Main()
    {
        // Example integer array
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Value to search for
        int targetValue = 3;

        // Call the function to search for the value
        int index = SearchValue(numbers, targetValue);

        // Display the result
        if (index != -1)
        {
            Console.WriteLine($"The value {targetValue} is found at index {index}.");
        }
        else
        {
            Console.WriteLine($"The value {targetValue} is not found in the array.");
        }
    }

    // Function to search for a value in an array and return its index
    static int SearchValue(int[] array, int targetValue)
    {
        // Loop through each element in the array
        for (int i = 0; i < array.Length; i++)
        {
            // Check if the current element matches the target value
            if (array[i] == targetValue)
            {
                return i; // Return the index if found
            }
        }

        return -1; // Return -1 if the value is not found
    }
}
8.Develop a C# program that finds the second smallest element in an integer array using loops and sorting techniques.
using System;

class Program
{
    static void Main()
    {
        // Example integer array
        int[] numbers = { 5, 3, 9, 1, 7, 2, 8, 4, 6 };

        // Call the function to find the second smallest element
        int secondSmallest = FindSecondSmallest(numbers);

        // Display the result
        Console.WriteLine($"The second smallest element in the array is: {secondSmallest}");
    }

    // Function to find the second smallest element in an array
    static int FindSecondSmallest(int[] array)
    {
        // Check if the array has at least two elements
        if (array.Length < 2)
        {
            throw new ArgumentException("Array should have at least two elements");
        }

        // Sort the array in ascending order
        Array.Sort(array);

        // The second smallest element is at index 1 after sorting
        return array[1];
    }
}

9.Create a C# program that removes all duplicates from an integer array using loops and additional data structures.
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Example integer array with duplicates
        int[] numbers = { 1, 2, 3, 2, 4, 5, 1, 6, 7, 8, 7, 9, 10, 10 };

        // Call the function to remove duplicates
        int[] uniqueNumbers = RemoveDuplicates(numbers);

        // Display the result
        Console.WriteLine("Array with duplicates removed:");
        foreach (int num in uniqueNumbers)
        {
            Console.Write(num + " ");
        }
    }

    // Function to remove duplicates from an array
    static int[] RemoveDuplicates(int[] array)
    {
        // Create a HashSet to store unique elements
        HashSet<int> uniqueSet = new HashSet<int>();
        List<int> uniqueList = new List<int>();

        // Loop through each element in the array
        foreach (int num in array)
        {
            // Check if the element is not in the HashSet
            if (uniqueSet.Add(num))
            {
                // Add the unique element to the HashSet and List
                uniqueList.Add(num);
            }
        }

        // Convert the List to an array
        return uniqueList.ToArray();
    }
}
10.Write a C# program that finds the common elements between two integer arrays using loops.
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Example integer arrays
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 3, 5, 7, 9, 11 };

        // Call the function to find common elements
        int[] commonElements = FindCommonElements(array1, array2);

        // Display the result
        Console.WriteLine("Common elements between the arrays:");
        foreach (int num in commonElements)
        {
            Console.Write(num + " ");
        }
    }

    // Function to find common elements between two arrays
    static int[] FindCommonElements(int[] array1, int[] array2)
    {
        // Create a HashSet to store elements from the first array
        HashSet<int> set1 = new HashSet<int>(array1);

        // Create a List to store common elements
        List<int> commonList = new List<int>();

        // Loop through each element in the second array
        foreach (int num in array2)
        {
            // Check if the element is present in the HashSet (common element)
            if (set1.Contains(num))
            {
                // Add the common element to the List
                commonList.Add(num);
            }
        }

        // Convert the List to an array
        return commonList.ToArray();
    }
}
