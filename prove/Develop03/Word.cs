class Word
{
    private string _word;
    private bool _isHidden = false;
    public Word(string word)
    {
        _word = word;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string Get()
    {
        if (!_isHidden)
        {
            return _word;
        }
        string output = "";
        foreach (char character in _word)
        {
            if (char.IsLetter(character))
                output += "_";
            else
                output += character;
        }
        return output;
    }
}