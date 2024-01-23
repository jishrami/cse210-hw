public class Job {
    public string _jobTitle;
    public string _companyName;
    public string _dateHired;
    public string _dateLeft;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_dateHired}-{_dateLeft}");
        
    }
}

