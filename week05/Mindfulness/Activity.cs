using System;
using System.Threading;

namespace MindfulnessApp
{
    public abstract class Activity
    {
        protected string _name;
        protected string _description; 
        protected int _duration;

        public Activity()
        {
            // Base constructor
        }

        public void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"║    Welcome to {_name,-10}   ║");
            Console.WriteLine($"\n{_description}");
            
            Console.Write($"\nHow long, in seconds, would you like for your session? ");
            string input = Console.ReadLine();
            
            if (!int.TryParse(input, out _duration) || _duration <= 0)
            {
                Console.WriteLine("Invalid input. Setting duration to 30 seconds.");
                _duration = 30;
            }

            Console.WriteLine($"\nGet ready to begin...");
            ShowSpinner(3);
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine($"║          Well done!          ║");
            ShowSpinner(2);
            Console.WriteLine($"\nYou have completed the {_name} activity for {_duration} seconds.");
            ShowSpinner(3);
        }

        public void ShowSpinner(int seconds)
        {
            DateTime endTime = DateTime.Now.AddSeconds(seconds);
            string[] spinner = { "⣼", "⣹", "⢻", "⠿", "⡟", "⣏", "⣧", "⣶" };
            int spinnerIndex = 0;

            while (DateTime.Now < endTime)
            {
                Console.Write($"\r{spinner[spinnerIndex]} Loading... ");
                spinnerIndex = (spinnerIndex + 1) % spinner.Length;
                Thread.Sleep(200);
            }
            Console.Write("\r" + new string(' ', 20) + "\r");
        }

        public void ShowCountDown(int seconds, string message = "")
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"\r{message} {i}... ");
                Thread.Sleep(1000);
            }
            Console.Write("\r" + new string(' ', message.Length + 10) + "\r");
        }

        public void ShowProgressBar(int totalSeconds, string activityName)
        {
            int barWidth = 30;
            for (int i = 0; i <= totalSeconds; i++)
            {
                double progress = (double)i / totalSeconds;
                int bars = (int)(progress * barWidth);
                
                Console.Write($"\r{activityName} [");
                Console.Write(new string('█', bars));
                Console.Write(new string('░', barWidth - bars));
                Console.Write($"] {i}/{totalSeconds}s");
                
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        public int GetDuration()
        {
            return _duration;
        }

        public abstract void Run();
    }
}