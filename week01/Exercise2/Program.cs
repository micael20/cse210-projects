using System;

class Program
{
    static void Main(string[] args)
    {
        // we prompt the user for input.
        Console.Write("What is your grade percentage? ");
        
        // We read the user's input from the console. 
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        // CORE REQUIREMENT 3: Create a single variable for the letter grade and print it once.
        string letterGrade = "";

        // Use a series of if-else if-else statements to determine the letter grade.
        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        // Print the final letter grade to the console.
        Console.WriteLine($"Your letter grade is: {letterGrade}");

        // CORE REQUIREMENT 2: Add a separate if statement to determine if the user passed.
        
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't worry, you can do better next time. Keep working hard!");
        }
    }
}
