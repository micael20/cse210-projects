using System;

class Program
{
    static void Main(string[] args)
    {
        // CORE REQUIREMENT 3: Instead of having the user supply the magic number,
        // we'll generate a random number from 1 to 100.
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        // We declare the guess variable outside the loop so we can check it later.
        int guess = -1;

        // CORE REQUIREMENT 2: Add a loop that keeps looping as long as the guess
        // does not match the magic number.
        // A do-while loop is perfect because we want to run the code at least once.
        do
        {
            // CORE REQUIREMENT 1: Ask the user for a guess.
            Console.Write("What is your guess? ");
            
            // Read the user's input and convert it to an integer.
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            // Use an if statement to determine if the user needs to guess higher or lower.
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                // This message is printed only when the guess is correct, 
                Console.WriteLine("You guessed it!");
            }

        } while (guess != magicNumber);
    }
}