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
class Program
{
    static void Main(string[] args)
    {

        Menu JournalMenu = new Menu();

        int userSelection = 0;
        userSelection = JournalMenu.ProcessMenu();

        switch (userSelection)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
        }
    }
}