using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class GratitudeActivity : Activity
    {
        private List<string> _gratitudePrompts;
        private List<string> _gratitudeCategories;

        public GratitudeActivity()
        {
            _name = "Gratitude";
            _description = "This activity will help you cultivate gratitude by reflecting on positive aspects of your life and writing a gratitude journal entry.";
            
            _gratitudePrompts = new List<string>
            {
                "What made you smile today? 😊",
                "Who are you thankful for and why? 👨‍👩‍👧‍👦", 
                "What simple pleasure are you grateful for? 🌸",
                "What challenge are you grateful for? 💪",
                "What skill or talent are you grateful for? 🎨",
                "What beauty did you notice recently? 🌅",
                "What opportunity are you grateful for? 🚀",
                "What lesson are you thankful for learning? 📚"
            };

            _gratitudeCategories = new List<string>
            {
                "People", "Experiences", "Nature", "Opportunities", "Personal Growth"
            };
        }

        public override void Run()
        {
            Random random = new Random();
            
            // Show gratitude categories
            Console.WriteLine("\nGratitude Categories:");
            for (int i = 0; i < _gratitudeCategories.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {_gratitudeCategories[i]}");
            }

            // Select random prompts
            Console.WriteLine("\nReflect on these prompts:");
            for (int i = 0; i < 3 && i < _gratitudePrompts.Count; i++)
            {
                string prompt = _gratitudePrompts[random.Next(_gratitudePrompts.Count)];
                Console.WriteLine($"  • {prompt}");
                ShowSpinner(2);
            }

            Console.WriteLine($"\nNow take {_duration} seconds to write your gratitude thoughts...");
            Console.WriteLine("Type your thoughts and press Enter after each one:");
            Console.WriteLine("(Type 'done' to finish early)\n");

            List<string> gratitudeItems = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            DateTime lastItemTime = DateTime.Now;

            while (DateTime.Now < endTime)
            {
                if (Console.KeyAvailable)
                {
                    Console.Write("I'm grateful for: ");
                    string item = Console.ReadLine();
                    
                    if (item?.ToLower() == "done")
                        break;
                        
                    if (!string.IsNullOrEmpty(item))
                    {
                        gratitudeItems.Add(item);
                        lastItemTime = DateTime.Now;
                        Console.WriteLine($"✓ Added! ({gratitudeItems.Count} items so far)\n");
                    }
                }

                // Show encouragement if no input for a while
                if ((DateTime.Now - lastItemTime).TotalSeconds > 10 && gratitudeItems.Count == 0)
                {
                    Console.WriteLine("\n💡 Tip: Start with something simple like 'a warm bed' or 'good health'");
                    lastItemTime = DateTime.Now;
                }

                // Show progress
                int timeLeft = (int)(endTime - DateTime.Now).TotalSeconds;
                if (timeLeft % 5 == 0) // Update every 5 seconds
                {
                    Console.Write($"\rTime left: {timeLeft}s | Items: {gratitudeItems.Count} | Keep going... ");
                }
                
                Thread.Sleep(1000);
            }

            DisplayGratitudeSummary(gratitudeItems);
        }

        private void DisplayGratitudeSummary(List<string> items)
        {
            Console.WriteLine($"║      Gratitude Journal       ║");
            
            Console.WriteLine($"\nYou expressed gratitude for {items.Count} things:\n");

            if (items.Count > 0)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"  {i + 1}. 🙏 {items[i]}");
                }

                Console.WriteLine($"\n🌈 Keep this gratitude in your heart throughout the day!");
                
                // Suggest one item to focus on
                Random random = new Random();
                string focusItem = items[random.Next(items.Count)];
                Console.WriteLine($"\n💫 Today, try to appreciate: '{focusItem}'");
            }
            else
            {
                Console.WriteLine("Even being here and trying is something to be grateful for! 🌟");
            }
        }
    }
}