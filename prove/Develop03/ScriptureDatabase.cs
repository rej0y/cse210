using System.Text.Json;

class ScriptureDatabase
{
    private List<Verse> _data = new List<Verse>();
    public ScriptureDatabase(string filename)
    {
        _data = JsonSerializer.Deserialize<List<Verse>>(
            File.ReadAllText(filename)
        );
    }
    public string GetTextFromReference(Reference reference)
    {
        var result = _data.Where(
            v => v.BookTitle == reference.GetBook() &&
            v.ChapterNumber == reference.GetChapter() &&
            v.VerseNumber >= reference.GetStartVerse() &&
            v.VerseNumber <= reference.GetEndVerse()
        )
        .OrderBy(v => v.VerseNumber)
        .ToList();

        return string.Join(
            " ",
            result.Select(v => v.ScriptureText)
        );
    }
}