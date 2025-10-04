using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    class Program
    {
        private static Dictionary<string, int> activityCounts = new Dictionary<string, int>
        {
            {"Breathing", 0},
            {"Reflection", 0},
            {"Listing", 0},
            {"Gratitude", 0}
        };

        private static int totalTime = 0;

        static void Main(string[] args)
        {
            Console.Title = "Mindfulness App";
            
            while (true)
            {
                ShowMenu();
                string choice = Console.ReadLine();

                Activity activity = null;
                string activityName = "";

                switch (choice)
                {
                    case "1":
                        activity = new BreathingActivity();
                        activityName = "Breathing";
                        break;
                    case "2":
                        activity = new ReflectingActivity();
                        activityName = "Reflection";
                        break;
                    case "3":
                        activity = new ListingActivity();
                        activityName = "Listing";
                        break;
                    case "4":
                        activity = new GratitudeActivity();
                        activityName = "Gratitude";
                        break;
                    case "5":
                        ShowSessionSummary();
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Press any key to continue.");
                        Console.ReadKey();
                        break;
                }

                if (activity != null)
                {
                    activity.DisplayStartingMessage();
                    totalTime += activity.GetDuration();
                    activity.Run();
                    activityCounts[activityName]++;
                    activity.DisplayEndingMessage();
                    
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"You've completed {activityName} activity {activityCounts[activityName]} times this session.");
                    Console.ResetColor();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("║      Mindfulness Activities  ║");
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1. 🌬️  Breathing Activity");
            Console.WriteLine("   Relax through controlled breathing");
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("2. 💭 Reflection Activity");
            Console.WriteLine("   Find strength in past experiences");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("3. 📝 Listing Activity");
            Console.WriteLine("   Recognize positive aspects of life");
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("4. 🙏 Gratitude Activity");
            Console.WriteLine("   Cultivate thankfulness (Bonus Activity)");
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("5. 🚪 Exit");
            Console.ResetColor();
            
            Console.WriteLine("\nTotal Session Time: " + FormatTime(totalTime));
            Console.Write("\nChoose an activity (1-5): ");
        }

        static void ShowSessionSummary()
        {
            Console.Clear();
            Console.WriteLine("║     Today's Mindfulness Session  ║");
            
            int totalActivities = 0;
            foreach (var entry in activityCounts)
            {
                if (entry.Value > 0)
                {
                    Console.WriteLine($"   {entry.Key}: {entry.Value} time(s)");
                    totalActivities += entry.Value;
                }
            }
            
            Console.WriteLine($"\n   Total Activities: {totalActivities}");
            Console.WriteLine($"   Total Time: {FormatTime(totalTime)}");
            Console.WriteLine("\n🌈 Thank you for taking time for mindfulness!");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static string FormatTime(int seconds)
        {
            if (seconds < 60)
                return $"{seconds} seconds";
            else
                return $"{seconds / 60} minutes {seconds % 60} seconds";
        }
    }
}