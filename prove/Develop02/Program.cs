using System;
using System.Runtime.InteropServices;

// string[] questions = [
//     "Who was the most interesting person I interacted with today?",
//     "What was the best part of my day?",
//     "How did I see the hand of the Lord in my life today?",
//     "What was the strongest emotion I felt today?",
//     "If I had one thing I could do over today, what would it be?"
//     ];



class Menu
{
    public string[] _menuString = [
            "1. Log an entry",
            "2. Display all entries",
            "3. save to file",
            "4. read from file",
            "5. Quit"
    ];

    public void ProcessMenu()
    {
        foreach (string menuItem in _menuString)
        {
            Console.WriteLine(menuItem);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {

        Menu JournalMenu = new Menu();

        JournalMenu.ProcessMenu();
    }
}