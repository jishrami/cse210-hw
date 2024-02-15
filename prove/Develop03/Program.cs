using System;
using System.ComponentModel;
class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("John", 3, 16);
        Reference reference2 = new Reference("John", 3, 16, 18);
        Reference reference3 = new Reference("2 Nephi", 2, 13);
        Reference test = new Reference("test", 1, 1, 1);
        Scripture scripture1 = new Scripture(reference1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Scripture scripture2 = new Scripture(reference2, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. For God sent not his Son into the world to condemn the world; but that the world through him might be saved. He that believeth on him is not condemned: but he that believeth not is condemned already, because he hath not believed in the name of the only begotten Son of God.");
        Scripture scripture3 = new Scripture(reference3, "And if ye shall say there is no law, ye shall also say there is no sin. If ye shall say there is no sin, ye shall also say there is no righteousness. And if there be no righteousness there be no happiness. And if there be no righteousness nor happiness there be no punishment nor misery. And if these things are not there is no God. And if there is no God we are not, neither the earth; for there could have been no creation of things, neither to act nor to be acted upon; wherefore, all things must have vanished away.");
        Scripture testScripture = new Scripture(test, "test test test test");

        List<Word> hiddenWords = new List<Word>();

        //names a scripture to reference, change the last digit to change the reference
        Scripture calledScripture = scripture1;

        //initial clear and print
        Console.Clear();
        Console.WriteLine(calledScripture.GetRenderedText());
        Console.WriteLine("Type 'quit' to exit the program.");
        Console.ReadLine();

        //creates a new list in Word by separating the words into individual strings
        List<Word> words = calledScripture.GetWords();
        int iterate = words.Count() / 3;
        int wordCount = words.Count();
        int hiddenWordCount = hiddenWords.Count();
        //checks to see if any words are not hidden, if they are, it will randomly hide a word, if not, it will quit
        for (int a = 0; a < iterate+1; a++)
        {
            for (int i = 0; i < 3; i++)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, wordCount);
                if (wordCount == hiddenWordCount)
                {
                    break;
                }   

                while (hiddenWords.Contains(words[randomIndex]))
                {
                    randomIndex = random.Next(0, wordCount);
                }

                words[randomIndex].Hide();
                hiddenWords.Add(words[randomIndex]);
                hiddenWordCount++;
            }
            Console.Clear();
            Console.WriteLine(calledScripture.GetRenderedText());
            Console.WriteLine("Type 'quit' to exit the program.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit" || a == iterate)
            {
                Console.Clear();
                break;
            }
        }
        Console.Clear();
    }

    //calls Word to see if any words are not hidden. Returns true if there are any not hidden
    static bool AnyNotHidden(List<Word> words)
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden())
            {
                return true;
            }
        }
        return false;
    }
}