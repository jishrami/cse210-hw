using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        string response = "yes";
        do
        {
            Random number = new Random();
            int magicNumber = number.Next(1,100);
            Console.WriteLine(magicNumber);
            int numberGuess;
            int amountGuess = 0;
                do
                {
                    Console.Write("What is your guess? ");
                    numberGuess = int.Parse(Console.ReadLine());
                    
                    if (numberGuess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else if (numberGuess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (numberGuess == magicNumber)
                    {
                        Console.WriteLine("You guessed it!");
                    }
                    amountGuess += 1;
                } while (numberGuess != magicNumber);

            if (amountGuess > 1)
            {
                Console.WriteLine($"You took {amountGuess} tries to guess");
            }
            else if (amountGuess == 1)
            {
                Console.WriteLine($"You took {amountGuess} try to guess");
            }
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } while (response.ToLower() == "yes");
    }
}