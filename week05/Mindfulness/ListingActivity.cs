using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts;
        private int _count;

        public ListingActivity()
        {
            _name = "Listing";
            _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
            _count = 0;
            
            _prompts = new List<string>
            {
                "Who are people that you appreciate? 👨‍👩‍👧‍👦",
                "What are personal strengths of yours? 💪", 
                "Who are people that you have helped this week? 🤝",
                "When have you felt the Holy Ghost this month? ✨",
                "Who are some of your personal heroes? 🦸",
                "What are you looking forward to? 🎯",
                "What made you happy recently? 😊",
                "What are you grateful for today? 🙏"
            };
        }

        public override void Run()
        {
            string prompt = GetRandomPrompt();
            Console.WriteLine($"\n{prompt}");
            
            Console.Write("\nGet ready to list items... ");
            ShowCountDown(5, "Starting in");

            List<string> items = GetListFromUser();
            _count = items.Count;

            Console.WriteLine($"\n🎉 Excellent! You listed {_count} items!");
            
            if (_count > 0)
            {
                Console.WriteLine("\nYour items:");
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"  {i + 1}. {items[i]}");
                }
            }
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            return _prompts[random.Next(_prompts.Count)];
        }

        public List<string> GetListFromUser()
        {
            List<string> items = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(_duration);

            Console.WriteLine($"\nStart listing now! (You have {_duration} seconds)");
            Console.WriteLine("Type your items and press Enter after each one:");
            Console.WriteLine("(Type 'done' to finish early)\n");

            while (DateTime.Now < endTime)
            {
                if (Console.KeyAvailable)
                {
                    string item = Console.ReadLine();
                    
                    if (item?.ToLower() == "done")
                        break;
                        
                    if (!string.IsNullOrEmpty(item))
                    {
                        items.Add(item);
                        Console.Write($"\rItems: {items.Count} | Time left: {(int)(endTime - DateTime.Now).TotalSeconds}s | ");
                    }
                }
                
                // Update timer display
                if (items.Count > 0)
                {
                    Console.Write($"\rItems: {items.Count} | Time left: {(int)(endTime - DateTime.Now).TotalSeconds}s | ");
                }
                
                Thread.Sleep(100);
            }

            return items;
        }
    }
}