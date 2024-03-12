class SimpleGoal : Goal
{
    private bool _goalStatus;

    public SimpleGoal(string goalType, string goalName, string goalDescription, int points) : base(goalType, goalName, goalDescription, points)
    {
    }

    public override void CreateNewGoal(List<Goal> goals)
    {
        Console.WriteLine("What is the name of your goal? ");
        string simpleGoalName = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        string simpleGoalDescription = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth? ");
        int simpleGoalPoints = int.Parse(Console.ReadLine());
        SimpleGoal simpleGoal = new SimpleGoal("Simple Goal", simpleGoalName, simpleGoalDescription, simpleGoalPoints);
        goals.Add(simpleGoal);
    }



    public override void RecordEvent()
    {

    }

    public void IsCompleted()
    {
        if (_goalStatus == true)
        {
            Console.Write("The goal has been completed.");
        }
        else
        {
            Console.WriteLine("The goal has not yet been completed.");
        }
    }

}