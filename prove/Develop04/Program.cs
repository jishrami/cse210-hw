using System;

class Program
{
    static void Main(string[] args)
    {
        int defaultDuration = 10;
        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", defaultDuration);

        breathingActivity.displayBreathing();

        ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        reflectionActivity.DisplayPrompt();

        ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", defaultDuration);
        listingActivity.DisplayActivity();
    }
}