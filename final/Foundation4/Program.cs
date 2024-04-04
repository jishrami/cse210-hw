using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("running", DateTime.Now, 60, 8);
        Cycling cycling = new Cycling("cycling", DateTime.Now, 120, 15);
        Swimming swimming = new Swimming("swimming", DateTime.Now, 30, 1);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);
        
        Console.WriteLine("Andres' Average Exercises");
        foreach (Activity activity in activities)
        {
            activity.displaySummary();
        }

    }
}