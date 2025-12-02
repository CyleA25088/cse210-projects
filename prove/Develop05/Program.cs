using System;

class Program
{
    static void DisplayMenu(string error = null)
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        if(error != null)
        {
            Console.WriteLine();
            Console.WriteLine(error);
            Console.CursorTop-=2;
        }
        Console.Write("> ");
    }
    static void Main(string[] args)
    {

        DisplayMenu();

        while (true)
        {
            string userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out int option) || option < 1 || option > 6)
            {
                DisplayMenu("Invalid input. Please enter a number between 1 and 6.");

                continue;
            }

            switch(option)
            {
                case 1:
                    Console.WriteLine("Create New Goal selected.");
                    break;
                case 2:
                    Console.WriteLine("List Goals selected.");
                    break;
                case 3:
                    Console.WriteLine("Save Goals selected.");
                    break;
                case 4:
                    Console.WriteLine("Load Goals selected.");
                    break;
                case 5:
                    Console.WriteLine("Record Event selected.");
                    break;
                case 6:
                    Console.WriteLine("Quitting the program. Goodbye!");
                    return;
                

            }
        
            DisplayMenu();
        }


        Console.WriteLine("Hello Develop05 World!");
    }
}