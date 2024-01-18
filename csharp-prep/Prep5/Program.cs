using System;

class Program
{

    static string UserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine(); 
        return userName;
    }

    static double SquaredNumber(int baseNumber, int sqr=2)
    {
        return Math.Pow(baseNumber, sqr);
    }

    static int EnteredNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int enteredNumber = int.Parse(Console.ReadLine());
        return enteredNumber;
    }

    static void Main(string[] args)
    {
        string usrname = UserName();
        int entrNumber = EnteredNumber();
        double sqrNumber = SquaredNumber(entrNumber);
        
        Console.WriteLine($"{usrname}, the square of your number is {sqrNumber}");
    }
}