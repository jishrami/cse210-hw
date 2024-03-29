using System;

class Program
{
    static void Main(string[] args)
    {
        int defaultDuration = 10;
        int userDuration;
        int userChoice = 0;
        Action<int> wait = (int time) => Thread.Sleep(time * 1000);

        Console.Clear();
        while (userChoice != 5)
        {
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Menu:\n1:Breathing Activity\n2:Reflection Activity\n3:Listing Activity\n4:Gratitude Activity\n5:Exit");
            Console.WriteLine("Select a choice from the menu:");
            userChoice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (userChoice)
            {
                case 1:
                    string name1 = "Breathing Activity";
                    string description1 = "This activity will help you relax by walking your through breathing in and out slowly.\nClear your mind and focus on your breathing.";

                    Activity activity1 = new Activity(name1, description1);
                    Console.WriteLine(activity1.DisplayStartingMessage());
                    wait(3);

                    Console.WriteLine("How much time, in seconds would you like this activity to last?");
                    userDuration = int.Parse(Console.ReadLine());
                    activity1.SetActivityDuration(userDuration);
                    BreathingActivity breathingActivity = new BreathingActivity(name1, description1, userDuration);

                    Console.Clear();

                    Console.WriteLine("Ready...");
                    activity1.ShowSpinner();

                    Console.Clear();

                    breathingActivity.displayBreathing();
                    wait(2);

                    Console.WriteLine("Well Done!");
                    activity1.ShowSpinner();

                    Console.Clear();

                    Console.WriteLine(activity1.DisplayEndMessage());
                    activity1.ShowSpinner();

                    Console.Clear();
                    break;

                case 2:
                    string name2 = "Reflection Activity";
                    string description2 = "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.";

                    Activity activity2 = new Activity(name2, description2, defaultDuration);
                    Console.WriteLine(activity2.DisplayStartingMessage());
                    wait(4);

                    Console.WriteLine("How much time, in seconds would you like this activity to last?");
                    userDuration = int.Parse(Console.ReadLine());
                    activity2.SetActivityDuration(userDuration);
                    ReflectionActivity reflectionActivity = new ReflectionActivity(name2, description2, userDuration);

                    Console.Clear();

                    Console.WriteLine("Ready...");
                    activity2.ShowSpinner();

                    Console.Clear();

                    reflectionActivity.DisplayActivity();

                    Console.WriteLine("Well Done!");
                    activity2.ShowSpinner();

                    Console.Clear();

                    Console.WriteLine(activity2.DisplayEndMessage());
                    activity2.ShowSpinner();

                    Console.Clear();
                    break;
                case 3:
                    string name3 = "Listing Activity";
                    string description3 = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

                    Activity activity3 = new Activity(name3, description3, defaultDuration);
                    Console.WriteLine(activity3.DisplayStartingMessage());
                    wait(3);

                    Console.WriteLine("How much time, in seconds would you like this activity to last?");
                    userDuration = int.Parse(Console.ReadLine());
                    activity3.SetActivityDuration(userDuration);
                    ListingActivity listingActivity = new ListingActivity(name3, description3, userDuration);

                    Console.Clear();

                    Console.WriteLine("Ready...");
                    activity3.ShowSpinner();

                    Console.Clear();

                    listingActivity.DisplayActivity();
                    wait(2);

                    Console.WriteLine("Well Done!");
                    activity3.ShowSpinner();

                    Console.Clear();

                    Console.WriteLine(activity3.DisplayEndMessage());
                    activity3.ShowSpinner();

                    Console.Clear();
                    break;
                case 4:
                    string name4 = "Gratitude Activity";
                    string description4 = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

                    Activity activity4 = new Activity(name4, description4);
                    Console.WriteLine(activity4.DisplayStartingMessage());
                    wait(3);

                    Console.WriteLine("How much time, in seconds would you like this activity to last?");
                    userDuration = int.Parse(Console.ReadLine());
                    activity4.SetActivityDuration(userDuration);
                    GratitudeActivity gratitudeActivity = new GratitudeActivity(name4, description4, userDuration);

                    Console.Clear();

                    Console.WriteLine("Ready...");
                    activity4.ShowSpinner();

                    Console.Clear();

                    gratitudeActivity.DisplayActivity();
                    wait(2);

                    Console.WriteLine("Well Done!");
                    activity4.ShowSpinner();

                    Console.Clear();

                    Console.WriteLine(activity4.DisplayEndMessage());
                    activity4.ShowSpinner();

                    Console.Clear();
                    break;
                case 5:
                    continue;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }



    }
}