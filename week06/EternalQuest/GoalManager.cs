using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private List<string> _bibleVerses;
    private Random _random;

    public GoalManager()
    {
        _score = 0;
        _random = new Random();
        InitializeBibleVerses();
    }

    private void InitializeBibleVerses()
    {
        _bibleVerses = new List<string>
        {
            "Philippians 4:13 - I can do all things through Christ who strengthens me.",
            "Jeremiah 29:11 - For I know the plans I have for you, declares the Lord...",
            "Isaiah 40:31 - Those who hope in the Lord will renew their strength.",
            "Proverbs 3:5-6 - Trust in the Lord with all your heart...",
            "Matthew 19:26 - With God all things are possible.",
            "Joshua 1:9 - Be strong and courageous. Do not be afraid...",
            "Romans 8:28 - In all things God works for the good...",
            "2 Timothy 1:7 - God gives us power, love and self-discipline.",
            "Psalm 46:1 - God is our refuge and strength.",
            "Hebrews 11:1 - Faith is confidence in what we hope for."
        };
    }

    private void ShowRandomBibleVerse()
    {
        int index = _random.Next(_bibleVerses.Count);
        Console.WriteLine("Bible Verse: " + _bibleVerses[index]);
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine($"Score: {_score}");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    LoadGoals();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals.");
            return;
        }

        Console.WriteLine("\nGoals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nGoal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose: ");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Target: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid type.");
                return;
        }
        Console.WriteLine("Goal created.");
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals.");
            return;
        }

        Console.WriteLine("\nSelect goal:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
        Console.Write("Choose: ");
        
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= _goals.Count)
        {
            Goal goal = _goals[choice - 1];
            
            if (goal.IsComplete())
            {
                Console.WriteLine("Already complete.");
                return;
            }

            goal.RecordEvent();
            
            int pointsEarned = goal.GetPoints();
            
            // For checklist goals, handle bonus
            if (goal is ChecklistGoal checklist && checklist.IsComplete())
            {
                pointsEarned += checklist.GetBonus();
            }

            _score += pointsEarned;
            Console.WriteLine($"Congratulations you have earned {pointsEarned} points.");
            
            // Show Bible verse when points earned
            if (pointsEarned > 0)
            {
                ShowRandomBibleVerse();
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Saved.");
    }

    public void LoadGoals()
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        using (StreamReader reader = new StreamReader(filename))
        {
            _score = int.Parse(reader.ReadLine());
            _goals.Clear();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                switch (parts[0])
                {
                    case "SimpleGoal":
                        _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4])));
                        break;
                    case "ChecklistGoal":
                        _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), 
                            int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                        break;
                }
            }
        }
        Console.WriteLine("Loaded.");
    }
}