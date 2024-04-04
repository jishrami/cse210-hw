using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("running", DateTime.Now, 30, 4.8);
        Cycling cycling = new Cycling("cycling", DateTime.Now, 30, 9.6);
        Swimming swimming = new Swimming("swimming", DateTime.Now, 30, 96);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            activity.displaySummary();
        }

    }
}