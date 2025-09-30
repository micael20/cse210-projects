using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment = new Assignment("Samuel Benett", "Division");
        string student = assignment.GetSummary();
        Console.WriteLine(student);


        MathAssignment assignment2 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        string text = assignment2.GetSummary();
        string homeworkList = assignment2.GetHomeworkList();
        Console.WriteLine(text);
        Console.WriteLine(homeworkList);

        WritingAssignment assignment3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        string name = assignment3.GetSummary();
        string information = assignment3.GetWritingInformation();
        Console.WriteLine(name);
        Console.WriteLine(information);


    }

}