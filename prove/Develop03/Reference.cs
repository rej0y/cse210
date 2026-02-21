class Reference
{
    string _book;
    int _chapter;
    int _startVerse;
    int _endVerse;
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public string GetBook()
    {
        return _book;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public int GetStartVerse()
    {
        return _startVerse;
    }
    public int GetEndVerse()
    {
        return _endVerse;
    }
    public string Get()
    {
        return $"{_book} {_chapter}:{_startVerse}" + $"{(_startVerse == _endVerse ? "" : $"-{_endVerse}")}";
    }
}