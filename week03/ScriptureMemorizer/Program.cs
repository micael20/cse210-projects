using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("1 Corinthians", 16, 14);
        string text = "Let all that you do be done with love.";

        Scripture scripture = new Scripture(reference, text);

        string userInput = "";

        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());

                Console.WriteLine("\nPress Enter to hide more words, type 'reset' to start over, or 'quit' to exit.");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "reset")
                {
                    scripture.ShowAllWords();
                }
                else if (userInput.ToLower() != "quit")
                {
                    scripture.HideRandomWords(3);
                }
            }

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
    
        }
    }
}

