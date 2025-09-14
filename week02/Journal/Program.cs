using System;

class Program
{
    static void Main(string[] args)

    {   // Creating an instance for the journal
        Journal theJournal = new Journal();

        // Creating an Instance for the PrpmptGenerator 
        PromptGenerator prompts = new PromptGenerator();
        
        int choice = 0;

        while (choice != 5)

        {
            // Print the following 
            Console.WriteLine("Please select the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do so?");

            // Get User Input
            string userInput = Console.ReadLine();
            choice = int.Parse(userInput);

            if (choice == 1)
            {
                string randomPrompt = prompts.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                Console.WriteLine("> ");
                string entryText = Console.ReadLine();

                DateTime theCurrenttime = DateTime.Now;
                string dateText = theCurrenttime.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = dateText;
                newEntry._promptText = randomPrompt;
                newEntry._entryText = entryText;

                Console.WriteLine("How are you feeling today?");
                string mood = Console.ReadLine();
                newEntry._mood = mood;

                theJournal.AddEntry(newEntry);
            }

            else if (choice == 2)
            {
                theJournal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.WriteLine("Enter the filename to load:");
                string fileName = Console.ReadLine();
                theJournal.LoadToFile(fileName);
                
                theJournal.DisplayAll();
            }

            else if (choice == 4)
            {
                Console.WriteLine("Enter the filename to save:");
                string fileName = Console.ReadLine();
                theJournal.SaveToFile(fileName);
            }

            else if (choice == 5)
            {
                Console.WriteLine("Quit");
            }

            else
            {
                Console.WriteLine("Invalid Input");
            }
     
        }
    }
        
}