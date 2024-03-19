using System.Collections;

abstract class Goal
{
    protected string _goalType;
    protected string _goalName;
    protected string _goalDescription;
    protected int _points;

    public Goal(string goalType, string goalName, string goalDescription, int points)
    {
        _goalType = goalType;
        _goalName = goalName;
        _goalDescription = goalDescription;
        _points = points;
    }

    public abstract void CreateNewGoal(List<Goal> goals);


    public static void ListGoal(List<Goal> goals)
    {
        Console.WriteLine("The goals are: ");

        foreach (Goal goal in goals)
        {
            if (goal.GetType() == typeof(ChecklistGoal))
            {
                Console.WriteLine($"[] {goal._goalName}: {goal._goalDescription} - {goal._points} points - {((ChecklistGoal)goal).BonusPoints} bonus points if completed {((ChecklistGoal)goal).TimesToAccomplish} times");
            }
            else
            {
                Console.WriteLine($"[] {goal._goalName}: {goal._goalDescription} - {goal._points} points");
            }
        }
    }

    public static void SaveGoal(ref int totalPoints, List<Goal> goals)
    {
        Console.WriteLine("What is the name of the file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter($"{fileName}.txt"))
        {
            outputFile.WriteLine($"totalPoints={totalPoints}");
            foreach (Goal goal in goals)
            {
                if (goal.GetType() == typeof(ChecklistGoal))
                {
                    ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                    outputFile.WriteLine($"{goal._goalType},{goal._goalName},{goal._goalDescription},{goal._points},{checklistGoal.TimesToAccomplish},{checklistGoal.BonusPoints}");
                }
                else
                {

                    outputFile.WriteLine($"{goal._goalType},{goal._goalName},{goal._goalDescription},{goal._points}");
                }
            }
        }
    }

    public static void LoadGoal(ref int totalPoints, List<Goal> goals)
    {
        Console.WriteLine("What is the name of the file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines($"{fileName}.txt");

        foreach (string line in lines)
        {
            if (line.StartsWith("totalPoints"))
            {
                if (totalPoints == 0)
                {
                    string[] totals = line.Split('=');
                    totalPoints = int.Parse(totals[1]);
                }
                // Skip the line with totalPoints
                continue;
            }

            string[] parts = line.Split(',');

            string goalType = parts[0];
            string goalName = parts[1];
            string goalDescription = parts[2];
            int points = int.Parse(parts[3]);

            switch (goalType)
            {
                case "Simple Goal":
                    SimpleGoal simpleGoal = new SimpleGoal(goalType, goalName, goalDescription, points);
                    goals.Add(simpleGoal);
                    break;
                case "Eternal Goal":
                    EternalGoal eternalGoal = new EternalGoal(goalType, goalName, goalDescription, points);
                    goals.Add(eternalGoal);
                    break;
                case "Checklist Goal":
                    int timesToAccomplish = int.Parse(parts[4]);
                    int bonusPoints = int.Parse(parts[5]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(goalType, goalName, goalDescription, points, timesToAccomplish, bonusPoints);
                    goals.Add(checklistGoal);
                    break;
                default:
                    Console.WriteLine($"Invalid goal type: {goalType}");
                    break;
            }
        }
    }

    public abstract void RecordEvent(ref int totalPoints, List<Goal> goals);
}