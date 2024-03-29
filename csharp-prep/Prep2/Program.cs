using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string inGradePerc = Console.ReadLine();
        int valueGradePerc = int.Parse(inGradePerc);
        string letterGrade;
        string gradeSuffix;
        string pass;
        if (valueGradePerc >= 0 && valueGradePerc <= 100)
        {
            if (valueGradePerc >= 70)
            {
                pass = "You passed!";
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
                pass = "You did not pass. Try again!";
                if (valueGradePerc >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }
            }
            if (valueGradePerc % 10 >= 7 && letterGrade != "A" && letterGrade != "F")
            {
                gradeSuffix = "+";
            }
            else if (valueGradePerc % 10 <= 3 && letterGrade != "F" && valueGradePerc != 100)
            {
                gradeSuffix = "-";
            }
            else
            {
                gradeSuffix = "";
            }
            Console.WriteLine($"Your letter grade is {letterGrade}{gradeSuffix}");
            Console.WriteLine(pass);
        }
        else 
        {
            Console.Write("Please input a grade percentage between 0-100");
        }
    }
}