class ListingActivity : Activity
{
    private string _prompt;
    private int _duration;
    private int _items;
    List<string> _prompts = new List<string>{
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"};
    List<string> itemsList = new List<string>();

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        string prompt = GetPrompt();
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
        _items = itemsList.Count();
        return _items;
    }

    public void DisplayActivity()
    {

        Console.WriteLine($"{_prompt}");
        Thread.Sleep(3000);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            itemsList.Add(item);
        }

    }

}