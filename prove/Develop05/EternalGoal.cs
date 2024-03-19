class EternalGoal : Goal
{
    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {

    }

    public override void CreateNewGoal(List<Goal> goals)
    {
        Console.WriteLine("What is the name of your goal? ");
        string eternalName = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        string eternalDescription = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth? ");
        int eternalPoints = int.Parse(Console.ReadLine());
        EternalGoal eternalGoal = new EternalGoal("Eternal Goal", eternalName, eternalDescription, eternalPoints);
        goals.Add(eternalGoal);
    }

    public override void RecordEvent(ref int totalPoints, List<Goal> goals)
    {
        totalPoints += _points;
        Console.WriteLine($"You have completed the event '{_goalName}' and earned {_points} points!");
    }


}