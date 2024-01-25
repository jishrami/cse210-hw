class Journal
{
    public void DisplayJournal(List<Entries> entries)
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"{entry._date} - Prompt: {entry._prompt} {entry._input}");
            Console.WriteLine("");
        }
    }
}