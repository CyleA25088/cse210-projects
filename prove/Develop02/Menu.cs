
//
// ──────────────────────────────────────────────────────────────
//   CLASS: Menu
//   PURPOSE: Displays menu options and handles user selection
// ──────────────────────────────────────────────────────────────
//
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
