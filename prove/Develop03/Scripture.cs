class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Scripture(Reference reference, string scripture)
    {
        //splits the string into an array of words and creates a new Word object for each word
        string[] wordArray = scripture.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
        _reference = reference;
    }

    public string GetRenderedText()
    {
        //returns the reference and the words
        string renderedText = "";
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                renderedText += "______ ";
            }
            else
            {
                renderedText += word.ToString() + " ";
            }
        }
        return $"{_reference.FormatReference()} {renderedText}";
    }

    public List<Word> GetWords()
    {
        //returns the list of words
        return _words;
    }
}