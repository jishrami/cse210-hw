using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        List<Goal> goals = new List<Goal>();
        int totalPoints = 0;
        int initialLength = goals.Count();
        int initialPoints = 0;


        Console.Clear();
        while (userChoice != 6)
        {
            Console.WriteLine($"You currently have {totalPoints} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1:Create New Goal\n2:List Goals\n3:Save Goals\n4:Load Goals\n5:Record Event\n6:Quit");
            userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1: //create Goals
                    Console.Clear();
                    Console.WriteLine("The types of goals are: \n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
                    Console.WriteLine("Which type of goal would you like to create? ");
                    int goalChoice = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (goalChoice)
                    {
                        case 1:
                            SimpleGoal newSimpleGoal = new SimpleGoal("", "", "", 0);
                            newSimpleGoal.CreateNewGoal(goals);
                            break;
                        case 2:
                            EternalGoal eternalGoal = new EternalGoal("", "", "", 0);
                            eternalGoal.CreateNewGoal(goals);
                            break;
                        case 3:
                            ChecklistGoal checklistGoal = new ChecklistGoal("", "", "", 0, 0, 0);
                            checklistGoal.CreateNewGoal(goals);
                            break;
                        default:
                            Console.WriteLine("That is not a valid choice.");
                            break;
                    }
                    break;
                case 2: //list goals
                    Console.Clear();
                    Goal.ListGoal(goals);
                    break;
                case 3: //save goals
                    Goal.SaveGoal(ref totalPoints, goals);
                    initialLength = goals.Count();
                    initialPoints = totalPoints;
                    Console.Clear();
                    break;
                case 4: //load goals
                    Goal.LoadGoal(ref totalPoints, goals);
                    initialLength = goals.Count();
                    initialPoints = totalPoints;
                    Console.Clear();
                    break;
                case 5: //record event
                    Console.Clear();
                    Console.WriteLine("What goal did you accomplish?: ");
                    Goal.ListGoal(goals);
                    int recordChoice = int.Parse(Console.ReadLine());
                    Goal selectedGoal = goals[recordChoice - 1];

                    if (selectedGoal is SimpleGoal simpleGoal)
                    {
                        simpleGoal.RecordEvent(ref totalPoints, goals);
                    }
                    else if (selectedGoal is EternalGoal eternalGoal)
                    {
                        eternalGoal.RecordEvent(ref totalPoints, goals);
                    }
                    else if (selectedGoal is ChecklistGoal checklistGoal)
                    {
                        checklistGoal.RecordEvent(ref totalPoints, goals);
                    }
                    break;

                case 6: //exit
                    Console.Clear();
                    int finalLength = goals.Count();
                    if (initialLength != finalLength || initialPoints != totalPoints)
                    {
                        Console.WriteLine("Would you like to save your changes? (y/n)");
                        string saveChoice = Console.ReadLine();

                        switch (saveChoice.ToLower())
                        {
                            case "y":
                                Goal.SaveGoal(ref totalPoints, goals);
                                break;
                            case "n":
                                break;
                        }
                    }
                    break;
            }
        }
    }
}