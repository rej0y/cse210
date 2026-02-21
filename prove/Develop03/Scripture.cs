class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();
    private bool _isAllHidden = false;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (string word in text.Split(' '))
        {
            Word w = new Word(word);
            _words.Add(w);
        }
    }
    public void HideWords(int hidingNumber)
    {
        List<int> visibleWordIndexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleWordIndexes.Add(i);
            }
        }
        if (hidingNumber >= visibleWordIndexes.Count)
        {
            hidingNumber = visibleWordIndexes.Count;
            _isAllHidden = true;
        }
        for (int n = 0; n < hidingNumber; n++)
        {
            int hidingIndex = visibleWordIndexes[
                _random.Next(visibleWordIndexes.Count)
            ];
            _words[hidingIndex].Hide();
            visibleWordIndexes.Remove(hidingIndex);
        }
    }
    public string GetText()
    {
        string output = "";
        foreach (Word word in _words)
        {
            output = output + word.Get() + " ";
        }
        return output;
    }
    public string GetReference()
    {
        return _reference.Get();
    }
    public bool IsAllHidden()
    {
        return _isAllHidden;
    }
}
