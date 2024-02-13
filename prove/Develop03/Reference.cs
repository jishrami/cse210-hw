class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        //sets the reference of book, chapter, and verse
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        //sets the reference of book, chapter, verse, and end verse
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string FormatReference()
    {
        //returns the reference as a string
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else //if there is an end verse
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}
