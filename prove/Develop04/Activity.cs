class Activity
{
    protected string _activityName;
    protected string _activityDescription;
    protected int _activityDuration;

    public Activity(string name, string description)
    {
        _activityName = name;
        _activityDescription = description;
    }

    public Activity(string name, string description, int duration)
    {
        _activityName = name;
        _activityDescription = description;
        _activityDuration = duration;
    }

    public void SetActivityDuration(int activityDuration)
    {
        _activityDuration = activityDuration;
    }


    public string DisplayStartingMessage()
    {
        return $"Welcome to the {_activityName}!\n{_activityDescription}";
    }

    public string DisplayEndMessage()
    {
        if (_activityDuration == 1)
        {
            return $"You have completed another {_activityDuration} second of the {_activityName}!";
        }
        else
        {
            return $"You have completed another {_activityDuration} seconds of the {_activityName}!";
        }
    }



    public void ShowSpinner()
    {

        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(4);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }

        }
        Console.WriteLine();
    }
}