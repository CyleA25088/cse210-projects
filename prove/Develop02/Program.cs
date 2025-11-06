using System;
using System.Runtime.InteropServices;

class Menu
{
    public string[] _menuString = [
            "1. Log an entry",
            "2. Display all entries",
            "3. save to file",
            "4. read from file",
            "5. Quit"
    ];

    public int ProcessMenu()
    {

        int userSelection = 0;

        do
        {
            foreach (string menuItem in _menuString)
            {
                Console.WriteLine(menuItem);
            }

            int.TryParse(Console.ReadLine(), out userSelection);

        } while (userSelection < 1 || userSelection > 5);

        return userSelection;

    }
}

class Entry
{
    string _date;
    string _prompt;
    string _response;

    public void FillEntry(string prompt)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd");
        _prompt = prompt;

        Console.WriteLine(prompt);
        Console.Write("> ");
        string input = Console.ReadLine() ?? "";

        // sanitize input: remove newlines, carriage returns, and trim spaces
        input = input.Replace("\r", "").Replace("\n", "").Trim();

        _response = input;
    }


    public void FillEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }

    public string EntryData()
    {
        return $"{_date}#{_prompt}#{_response}";
    }
}


class Journal
{
    public List<Entry> _entryList = new List<Entry>();

    public string _fileLocation=null;

    public void displayEntries()
    {
        foreach (Entry entry in _entryList)
        {
            entry.Display();
        }
    }

    public void SaveFile()
    {
        if (_fileLocation == null) return;

        using (StreamWriter outputFile = new StreamWriter(_fileLocation))
        {
            foreach (Entry entry in _entryList)
            {
                outputFile.WriteLine(entry.EntryData());
            }
        }
    }
    
    public void ReadFile()
    {
        string[] lines = System.IO.File.ReadAllLines(_fileLocation);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            Entry entry = new Entry();
            entry.FillEntry(date, prompt, response);

            _entryList.Add(entry);
        }
    }
}

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

        userJournal._fileLocation="./myJournalData.txt";

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
                    // read from a file
                    break;
                case 5:
                    return;
            }
        }
    }
}