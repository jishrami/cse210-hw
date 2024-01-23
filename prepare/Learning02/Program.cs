using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._dateHired = "2024";
        job1._dateLeft = "Present";

        Job job2 = new Job();
        job2._jobTitle = "Project Manager";
        job2._companyName = "Hewlett Packard ";
        job2._dateHired = "2019";
        job2._dateLeft = "2024";

        Resume person1 = new Resume();
        person1._employeeName = "Adam Jacobs";

        person1._jobs.Add(job1);
        person1._jobs.Add(job2);

        person1.Display();
    }
}