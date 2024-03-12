using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        List<Goal> goals = new List<Goal>();

        Console.Clear();
        while (userChoice != 6)
        {
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
                            SimpleGoal simpleGoal = new SimpleGoal("","","",0);
                            simpleGoal.CreateNewGoal(goals);
                            break;
                        case 2:
                            EternalGoal eternalGoal = new EternalGoal("","","",0);
                            eternalGoal.CreateNewGoal(goals);
                            break;
                        case 3:
                           ChecklistGoal checklistGoal = new ChecklistGoal("","","",0,0,0);
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
                    Goal.SaveGoal(goals);
                    Console.Clear();
                    break;
                case 4: //load goals
                    Goal.LoadGoal(goals);
                    Console.Clear();
                    break;
                case 5: //record event
                    Console.Clear();
                    break;
                case 6: //exit
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Please enter a valid choice");
                    break;
            }
        }
    }
}