class ListingActivity : Activity
{
    private string _prompt;
    private int _items;
    List<string> _prompts = new List<string>{
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"};
    List<string> itemsList = new List<string>();

    public ListingActivity(string name, string description, string prompt) : base(name, description)
    {
        _prompt = prompt;
    }

    Random random = new Random();

    public string GetPrompt()
    {
        int randomIndex = random.Next(_prompts.Count);
        _prompt = _prompts[randomIndex];
        return _prompt;
    }

    public int DisplayNumberItems()
    {
        Console.WriteLine($"{_prompt}");
        while (itemsList.Count() < 4) //TODO change to be timed
        {
        string item = Console.ReadLine();
        itemsList.Add(item);
        }
        return itemsList.Count();
    }

}