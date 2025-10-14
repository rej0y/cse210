using System.IO;
using System.Text.Json;

class Journal
{

    public static List<Entry> _entries = new();
    public static bool _journalRunning = true;

    public static int MenuPrompt()
    {
        // Output the introduction.
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        // Prompt the user for the option and return it.
        Console.Write("What would you like to do? ");
        return int.Parse(Console.ReadLine());
    }

    public static void DecideOption(int option)
    {
        switch (option)
        {
            case 1:

                // Define a new entry.
                Entry newEntry = new();

                // Generate a random prompt and store it in the new entry.
                string newPrompt = PromptGenerator.GetPrompt();
                newEntry._prompt = newPrompt;

                // Output the prompt.
                Console.WriteLine(newPrompt);

                // Let the user input the content and store the content.
                Console.Write("> ");
                newEntry._content = Console.ReadLine();

                // Store the date and time.
                newEntry._dateTime = DateTime.Now;

                // Add the new entry to the list.
                _entries.Add(newEntry);

                break;

            case 2:

                // Output a blank line.
                Console.WriteLine();

                // Output every entries.
                foreach (Entry entry in _entries)
                {
                    Console.WriteLine($"Date: {entry._dateTime:d} - Prompt: {entry._prompt}");
                    Console.WriteLine(entry._content);
                    Console.WriteLine();
                }

                break;

            case 3:

                // Prompt the user for the file name.
                Console.Write("What is the JSON file name? ");
                string readFilename = Console.ReadLine();

                // Read the file.
                // string[] lines = System.IO.File.ReadAllLines(readFilename);
                // foreach (string line in lines)
                // {
                //     string[] parts = line.Split(" | ");

                //     // Create a new journal entry.
                //     Entry readNewEntry = new();

                //     // Set the contents and add it to the list.
                //     readNewEntry._dateTime = DateTime.Parse(parts[0]);
                //     readNewEntry._prompt = parts[1];
                //     readNewEntry._content = parts[2];
                //     entries.Add(readNewEntry);

                // }

                // Read the JSON file.
                // ChatGPT, personal communication, October 11, 2025
                var readJsonOptions = new JsonSerializerOptions { IncludeFields = true };
                string readJson = File.ReadAllText(readFilename);
                _entries = JsonSerializer.Deserialize<List<Entry>>(readJson, readJsonOptions) ?? new List<Entry>();
                Console.WriteLine("Journal loaded.");


                break;

            case 4:

                // Prompt the user for the file name.
                Console.Write("What is the JSON file name? ");
                string writeFilename = Console.ReadLine();

                // Store the entries into the file.
                // using (StreamWriter outputFile = new StreamWriter(writeFilename))
                // {
                //     foreach (Entry entry in entries)
                //     {
                //         outputFile.WriteLine($"{entry._dateTime} | {entry._prompt} | {entry._content}");
                //     }
                // }

                // Store the entries into the JSON file.
                // ChatGPT, personal communication, October 11, 2025
                var writeJsonOptions = new JsonSerializerOptions { WriteIndented = true, IncludeFields = true };
                string writeJson = JsonSerializer.Serialize(_entries, writeJsonOptions);
                File.WriteAllText(writeFilename, writeJson);
                Console.WriteLine("Journal saved.");

                break;

            case 5:

                // Set the "journalRunning" to false to exit the program loop.
                _journalRunning = false;

                break;

            default:

                Console.WriteLine("Not a valid input.");
                break;
        }
    }
}