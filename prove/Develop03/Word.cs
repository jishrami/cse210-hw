class Word
{
    private string _word;
    private bool _wordState;

    public Word(string word)
    {
        //sets the word and the state of the word
        _word = word;
        _wordState = false; //Shown by default
    }

    public void Hide()
    {
        //changes the state of the word to hidden
        _wordState = true;
    }

    public void Show()
    {
        //changes the state of the word to shown
        _wordState = false;
    }

    public bool IsHidden()
    {
        //returns the state of the word
        return _wordState;
    }

    public override string ToString()
    {
        //returns the word as a string
        return _word;
    }
}