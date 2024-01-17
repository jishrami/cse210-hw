using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int listInput;
        List<int> userInput;
        userInput = new List<int>();
        int sumInput = 0;
        int largeNum = 0;
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter a number: ");
            listInput = int.Parse(Console.ReadLine());
            if (listInput != 0)
            {
                userInput.Add(listInput);
            }
            sumInput += listInput;
            if (listInput > largeNum)
            {
                largeNum = listInput;
            }

        }while (listInput != 0);

        float avgNum = (float)sumInput / userInput.Count;

        Console.WriteLine($"The sum is: {sumInput}");
        Console.WriteLine($"The average is: {avgNum}");
        Console.WriteLine($"The largest number is: {largeNum}");
    }
}