class ReflectionActivity : Activity
{
    private string _prompt;
    private string _question;

    public ReflectionActivity(string name, string description) : base(name, description)
    {
        string prompt = GetRandomPrompt();
        string question = GetRandomQuestion();

        _prompt = prompt;
        _question = question;
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

        return prompts[random.Next(prompts.Count())];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(_prompt);
        Thread.Sleep(3000);
    }

    public string GetRandomQuestion()
    {
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
        return questions[random.Next(questions.Count())];
    }

    public void DisplayQuestion()
    {
        Console.WriteLine(_question);
        Thread.Sleep(3000);
    }
}