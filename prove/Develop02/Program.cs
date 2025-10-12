using System;
using System.Security.Cryptography.X509Certificates;



// This program can also choose 20 random journal prompts and store the data into a JSON file.
class Program
{
    static void Main(string[] args)
    {
        while (Journal.journalRunning)
        {
            Journal.DecideOption(Journal.MenuPrompt());
        }
    }

}