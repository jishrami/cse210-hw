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

        Console.WriteLine($"{job1._jobTitle} ({job1._companyName}) {job1._dateHired}-{job1._dateLeft}");
    }
}