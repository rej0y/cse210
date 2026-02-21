// Exceeding requirements: This program can ask the user for a reference and help the user
// memorize any verses from the official Church of Jesus Christ of Latter-day Saints
// scriptures; it can also handle most of the user input crashes.


using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Load a scripture database.
        ScriptureDatabase scriptureDatabase = new ScriptureDatabase("lds-scriptures.json");
        
        // // Set the scripture from the scripture database and the reference.
        Scripture scripture = GetScriptureFromUserInput(scriptureDatabase);
        
        // Program loop.
        while (true)
        {
            // Clear the terminal.
            Console.Clear();

            // Output the reference.
            Console.WriteLine($"{scripture.GetReference()} {scripture.GetText()}");
            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to finish: ");

            // Exit the loop if the user typed quit.
            if (Console.ReadLine() == "quit" || scripture.IsAllHidden()) { break; }

            // Hide some words.
            scripture.HideWords(3);
        }
    }
    static Scripture GetScriptureFromUserInput(ScriptureDatabase scriptureDatabase)
    {
        while (true)
        {
            Console.Write("What verse(s) do you want to memorize? (e.g., Proverbs 3:5-6) ");
            string input = Console.ReadLine();

            Match match = Regex.Match(
                input,
                @"^(?<book>.+?)\s+(?<chapter>\d+):(?<start>\d+)(-(?<end>\d+))?$"
            );

            if (!match.Success)
            {
                Console.WriteLine("That's not a correct format, please try again.");
            }
            else
            {
                Reference reference = new Reference(
                    book: match.Groups["book"].Value,
                    chapter: int.Parse(match.Groups["chapter"].Value),
                    startVerse: int.Parse(match.Groups["start"].Value),
                    endVerse: match.Groups["end"].Success
                        ? int.Parse(match.Groups["end"].Value)
                        : int.Parse(match.Groups["start"].Value)
                );

                string text = scriptureDatabase.GetTextFromReference(reference);
                if (string.IsNullOrWhiteSpace(text))
                {
                    Console.WriteLine("Could not find the correct scripture, please try again.");
                }
                else
                {
                    return new Scripture(reference, text);
                }
            }
        }
    }
}