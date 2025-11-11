using System;
using System.Runtime.InteropServices;
using System.IO;

//
// ──────────────────────────────────────────────────────────────
//   CLASS: Program
//   PURPOSE: Main execution class that controls program flow
// ──────────────────────────────────────────────────────────────
//
class Program
{
    static string[] _questions = [
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    ];

    static string ChooseRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_questions.Length);

        return _questions[index];
    }


    static void Main(string[] args)
    {
        Journal userJournal = new Journal();
        Menu journalMenu = new Menu();

        userJournal._fileLocation = "./myJournalData.txt";

        int userSelection = 0;

        while (true)
        {
            userSelection = journalMenu.ProcessMenu();

            switch (userSelection)
            {
                case 1:
                    string newPrompt = ChooseRandomPrompt();
                    Entry newEntry = new Entry();

                    newEntry.FillEntry(newPrompt);

                    userJournal._entryList.Add(newEntry);
                    break;
                case 2:
                    userJournal.displayEntries();
                    break;
                case 3:
                    userJournal.SaveFile();
                    Console.WriteLine("Journal saved successfully!");
                    break;
                case 4:
                    userJournal.ReadFile();
                    Console.WriteLine("Journal read successfully!");
                    break;
                case 5:
                    return;
            }
        }
    }
}