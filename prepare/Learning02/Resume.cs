public class Resume {
    public string _employeeName;
    public List<Job> _jobs = new List<Job>();


    public void Display()
    {
        Console.WriteLine($"Name: {_employeeName}");
        Console.WriteLine("Jobs:" );

            foreach (Job j in _jobs)
            {
                j.Display();
            }
    }
}