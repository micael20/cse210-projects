using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _questions;

        public ReflectingActivity()
        {
            _name = "Reflection";
            _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
            
            _prompts = new List<string>
            {
                "Think of a time when you stood up for someone else. 🛡️",
                "Think of a time when you did something really difficult. 💪", 
                "Think of a time when you helped someone in need. 🤝",
                "Think of a time when you did something truly selfless. ❤️",
                "Think of a time when you overcame a great fear. 🦸",
                "Think of a time when you made someone smile. 😊"
            };

            _questions = new List<string>
            {
                "Why was this experience meaningful to you? 💭",
                "Have you ever done anything like this before? 🔄",
                "How did you get started? 🚀",
                "How did you feel when it was complete? 🌈",
                "What made this time different than other times when you were not as successful? ⭐",
                "What is your favorite thing about this experience? 🎯",
                "What could you learn from this experience that applies to other situations? 📚",
                "What did you learn about yourself through this experience? 👤",
                "How can you keep this experience in mind in the future? 🗓️",
                "Who else was involved and how did it affect them? 👥"
            };
        }

        public override void Run()
        {
            string prompt = GetRandomPrompt();
            DisplayPrompt(prompt);

            Console.WriteLine($"\nReflection will continue for {_duration} seconds...");
            ShowProgressBar(_duration, "Reflecting");

            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            int questionCount = 0;
            
            while (DateTime.Now < endTime && questionCount < 5) // Max 5 questions
            {
                string question = GetRandomQuestion();
                DisplayQuestions(question);
                questionCount++;
            }

            Console.WriteLine($"\nYou reflected on {questionCount} meaningful questions.");
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            return _prompts[random.Next(_prompts.Count)];
        }

        public string GetRandomQuestion()
        {
            Random random = new Random();
            return _questions[random.Next(_questions.Count)];
        }

        public void DisplayPrompt(string prompt)
        {
            Console.WriteLine($"\nReflect on this: {prompt}");
            Console.WriteLine("\nWhen you have something in mind, press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(5, "Starting");
            Console.WriteLine();
        }

        public void DisplayQuestions(string question)
        {
            Console.Write($"\n> {question} ");
            ShowSpinner(8);
        }
    }
}