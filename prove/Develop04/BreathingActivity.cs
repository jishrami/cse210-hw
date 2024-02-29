class BreathingActivity : Activity
{
    private int _breathingTime;

    public BreathingActivity(string name, string description, int breathingTime) : base(name, description)
    {
        _breathingTime = breathingTime;
    }

    public void displayBreathing()
    {
        int inDuration = 5; // Each interval lasts for 5 seconds
        int outDuration = (int)Math.Round(inDuration * 1.1);
        DateTime endTime = DateTime.Now.AddSeconds(_breathingTime);

        do
        {
            Console.Write($"Now breathing in for {inDuration} seconds");
            for (int j = 0; j < inDuration; j++)
            {
                Console.Write(".");
                Thread.Sleep(1000); // 1 second
            }
            Console.WriteLine();

            Console.Write($"Now breathing out for {outDuration} seconds");
            for (int j = 0; j < outDuration; j++)
            {
                Console.Write(".");
                Thread.Sleep(1000); // 1 second
            }
            Console.WriteLine();

        } while (DateTime.Now < endTime);
    }

}