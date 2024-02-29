class GratitudeActivity : Activity
{
    private string _prompt;
    private List<string> gratitudeQuestions = new List<string>
    {
        "What are three things that made you smile today?",
        "Who has helped you recently, and how did they make a difference in your life?",
        "What abilities or skills are you grateful to have?",
        "What is something you often take for granted that you're thankful for?",
        "How has someone shown you kindness recently?",
        "What's a happy memory you cherish?",
        "What opportunities are you grateful to have had in your life?",
        "Who or what motivates you to be your best self?",
        "How has adversity helped you grow or learn?",
        "What about nature are you most grateful for?",
        "Who are you thankful to have in your life, and why?",
        "What is something new you've learned recently that you're grateful for?",
        "How have past challenges helped shape who you are today?",
        "What aspects of your health and well-being are you thankful for?",
        "What simple pleasures in life bring you joy?"
    };

    private List<string> userInput = new List<string>();

    private Random random = new Random();

    public GratitudeActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompt = GetRandomQuestion();
    }

    public string GetRandomQuestion()
    {
        return gratitudeQuestions[random.Next(gratitudeQuestions.Count)];
    }

    public void DisplayActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);
        
        while (startTime < endTime)
        {
            Console.WriteLine($"{_prompt}");
            string userResponse = Console.ReadLine();
            userInput.Add(userResponse);
            startTime = DateTime.Now;
            Console.Clear();
        }
        int items = userInput.Count;

        Console.WriteLine($"You wrote {items} items. Here's what you wrote in response to \n{_prompt}:");
        foreach (string i in userInput)
        {
            Console.WriteLine(i);
        }
    }
}