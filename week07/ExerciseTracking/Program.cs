using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");


        Activity running = new Running("03 Nov 2022", 30, 3.0);
        Activity cycling = new Cycling("03 Nov 2022", 30, 9.7);
        Activity swimming = new Swimming("03 Nov 2022", 30, 20);
        
        // Put all activities in one list
        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);
        
        // Display summaries for all activities
        Console.WriteLine("Exercise Tracking Summary:");
      ;
        
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}