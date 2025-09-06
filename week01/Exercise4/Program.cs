using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a new list to store the numbers.
        List<int> numbers = new List<int>();

        // We declare the number variable outside the loop.
        int number = -1;

        // Ask the user to enter a series of numbers and append them to the list.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        do
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            // Add the number to the list only if it's not 0.
            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        // CORE REQUIREMENT 1: Compute the sum, or total, of the numbers in the list.
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // CORE REQUIREMENT 2: Compute the average of the numbers in the list.
        double average = (double)sum / numbers.Count;

        // CORE REQUIREMENT 3: Find the maximum, or largest, number in the list.
        int max = 0;
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        // Display the results.
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}

