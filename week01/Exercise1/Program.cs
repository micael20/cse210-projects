using System;

class Program
{
    static void Main(string[] args)
    {
        // declare a variable of type `string` to store the user's first name.
        string firstName;

        // use `Console.Write` to print a message to the user.
        Console.Write("What is your first name? ");

        // use `Console.ReadLine` to read the user's input and store it.
        firstName = Console.ReadLine();

        // declare a variable of type `string` to store the user's last name.
        string lastName;

        // use `Console.Write` to print a message to the user.
        Console.Write("What is your last name? ");

        // use `Console.ReadLine` to read the user's input and store it.
        lastName = Console.ReadLine();

        // This prints the final line in the format.
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}
