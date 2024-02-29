class ReflectionActivity : Activity
{
    private string _prompt;
    private string _question;
    private List<string> _usedQuestions = new List<string>();
    List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };


    public ReflectionActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompt = GetRandomPrompt();
        _question = GetRandomQuestion();
    }

    Random random = new Random();

    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        return prompts[random.Next(prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        string question = questions[random.Next(questions.Count)];
        _usedQuestions.Add(question);
        return question;
    }

    public void DisplayActivity()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"------{_prompt}------");
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following as it relates to this experience.");
        Console.WriteLine("You may begin in: ");
        int countDown = 3;
        while (countDown > 0)
        {
            Console.Write(countDown);
            countDown--;
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine(_question);
            Thread.Sleep(_activityDuration * 1000 / 5);
            _question = GetRandomQuestion();
            questions.Remove(_question);
        }
    }
}
