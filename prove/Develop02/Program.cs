using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is a new skill or knowledge I acquired today?",
            "Describe a moment that brought you joy or made you smile today.",
            "How did I handle a challenging situation today, and what did I learn from it?",
            "What is something you are grateful for today?",
            "Reflect on a meaningful conversation you had today and its impact."
        };
        List<Entries> journalEntries = new List<Entries>();
        int userInput = 0;
        Random random = new Random();
        while (userInput != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            userInput = int.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                // Write
                int randomIndex = random.Next(prompts.Count);
                string randomPrompt = prompts[randomIndex];
                Entries entry = new Entries();
                entry._prompt = randomPrompt;
                Console.WriteLine(randomPrompt);
                entry._input = Console.ReadLine();
                entry._date = DateTime.Now.ToString("MM/dd/yyyy");
                journalEntries.Add(entry);
            }
            else if (userInput == 2)
            {
                //Display
                Journal journal = new Journal();
                journal.DisplayJournal(journalEntries);
            }
            else if (userInput == 3)
            {
                // Load
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines($"{fileName}.txt");

                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 3)
                    {
                        Entries entry = new Entries
                        {
                            _date = parts[0],
                            _prompt = parts[1],
                            _input = parts[2]
                        };
                        journalEntries.Add(entry);
                    }
                }
            }
            else if (userInput == 4)
            {
                // Save
                Console.WriteLine("What is the file name? (Not the file type!)");
                string fileName = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter($"{fileName}.txt"))
                {
                    foreach (Entries entry in journalEntries)
                    {
                        outputFile.WriteLine($"{entry._date}:{entry._prompt}:{entry._input}");
                    }
                }
                using (StreamWriter csvFile = new StreamWriter($"{fileName}.csv"))
                {
                    csvFile.WriteLine("Date,Prompt,Entry");
                    foreach (Entries entry in journalEntries)
                    {
                        string formattedPrompt = $"\"{entry._prompt}\"";
                        string formattedInput = $"\"{entry._input}\"";
                        csvFile.WriteLine($"{entry._date},{formattedPrompt},{formattedInput}");
                    }
                }
            }
        }
    }
}