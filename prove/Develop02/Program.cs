using System;
using System.Security.Cryptography.X509Certificates;

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