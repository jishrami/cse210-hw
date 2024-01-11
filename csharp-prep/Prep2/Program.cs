using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string inGradePerc = Console.ReadLine();
        int valueGradePerc = int.Parse(inGradePerc);
        string letterGrade;
        string gradeSuffix;
        if (valueGradePerc >= 0 && valueGradePerc <= 100)
        {
            if (valueGradePerc >= 70)
            {
                Console.WriteLine("You passed!");
                if (valueGradePerc < 80)
                {
                    letterGrade = "C";
                }
                else if (valueGradePerc < 90)
                {
                    letterGrade = "B";
                }
                else
                {
                    letterGrade = "A";
                }
            }
            else
            {
                Console.WriteLine("You did not pass. Try again!");
                if (valueGradePerc >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }
            }
            
            Console.WriteLine($"Your letter grade is {letterGrade}");
        }
    }
}