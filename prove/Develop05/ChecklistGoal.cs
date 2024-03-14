class ChecklistGoal : Goal
{
    private bool _goalStatus;
    private int _currentlyAccomplished;
    private int _timesToAccomplish;
    private int _bonusPoints;

    public ChecklistGoal(string type, string name, string description, int point, int timesToAccomplish, int bonusPoints) : base(type, name, description, point)
    {
        _timesToAccomplish = timesToAccomplish;
        _bonusPoints = bonusPoints;
    }

    public override void CreateNewGoal(List<Goal> goals)
    {
        Console.WriteLine("What is the name of your goal? ");
        string checkName = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        string checkDescription = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth? ");
        int checkPoints = int.Parse(Console.ReadLine());
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        int checkTime = int.Parse(Console.ReadLine());
        Console.WriteLine("How many bonus points does this goal give? ");
        int checkBonus = int.Parse(Console.ReadLine());
        ChecklistGoal checklistGoal = new ChecklistGoal("Checklist Goal", checkName, checkDescription, checkPoints, checkTime, checkBonus);
        goals.Add(checklistGoal);
    }


    public override void RecordEvent(List<Goal> goals)
    {

    }
}