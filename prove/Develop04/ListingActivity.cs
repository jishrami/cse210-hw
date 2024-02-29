class ListingActivity : Activity
{
    private string _prompt;
    private int _duration;
    private int _items;
    private List<string> itemsList = new List<string>();
    List<string> _prompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompt = GetPrompt();
        _duration = duration;
    }

    Random random = new Random();

    public string GetPrompt()
    {
        int randomIndex = random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }

    public void DisplayActivity()
    {
        Console.WriteLine($"{_prompt}");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            itemsList.Add(item);
        }

        _items = itemsList.Count;
        Console.WriteLine($"You listed {_items} items!");
    }
}