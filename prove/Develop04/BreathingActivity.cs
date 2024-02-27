class BreathingActivity : Activity
{
    private int _breathingTime;

    public BreathingActivity(string name, string description, int breathingTime) : base(name, description)
    {
        _breathingTime = breathingTime;
    }

    public void displayBreathing()
    {
        int inTime = _breathingTime / 4;
        int outTime = (int)(inTime * 1.5);

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Now breathing in for {inTime} seconds");
            for (int j = 0; j < inTime; j++)
            {
                Console.Write(".");
                Thread.Sleep(1000); // 1 second
            }
            Console.WriteLine();

            Console.Write($"Now breathing out for {outTime} seconds");
            for (int j = 0; j < outTime; j++)
            {
                Console.Write(".");
                Thread.Sleep(1000); // 1 second
            }
            outTime++;
            Console.WriteLine();
        }
    }
}