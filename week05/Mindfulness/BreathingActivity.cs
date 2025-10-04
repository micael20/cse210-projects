using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class BreathingActivity : Activity
    {
        private int _count;
        private List<string> _prompts;

        public BreathingActivity()
        {
            _name = "Breathing";
            _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
            _count = 0;
            _prompts = new List<string> 
            { 
                "Breathe in... 🌬️", 
                "Breathe out... 💨" 
            };
        }

        public override void Run()
        {
            Console.WriteLine("\nStarting breathing exercise...\n");
            
            int breathDuration = 6; // 3s in, 3s out
            int cycles = _duration / breathDuration;
            int actualDuration = cycles * breathDuration;

            if (actualDuration != _duration)
            {
                Console.WriteLine($"Note: Adjusted to {actualDuration} seconds for complete breathing cycles.");
            }

            for (int i = 0; i < cycles; i++)
            {
                // Breathe in with expanding animation
                Console.Write($"\r{_prompts[0]} ");
                ShowBreathingAnimation(true, 3);
                Console.WriteLine();
                
                // Breathe out with contracting animation  
                Console.Write($"\r{_prompts[1]} ");
                ShowBreathingAnimation(false, 3);
                Console.WriteLine();
                Console.WriteLine();
                
                _count++;
                
                // Show progress
                if (i < cycles - 1)
                {
                    Console.WriteLine($"Completed {i + 1}/{cycles} breathing cycles");
                    ShowSpinner(1);
                }
            }
        }

        private void ShowBreathingAnimation(bool breatheIn, int seconds)
        {
            string[] inFrames = { "○", "◎", "●", "🎈" };
            string[] outFrames = { "●", "◎", "○", " " };
            string[] frames = breatheIn ? inFrames : outFrames;

            for (int i = 0; i < seconds; i++)
            {
                foreach (string frame in frames)
                {
                    Console.Write($"\r{(breatheIn ? _prompts[0] : _prompts[1])} {frame} ");
                    Thread.Sleep(250);
                }
            }
        }
    }
}