public static class InputHandler
{
    public static int GetMenuSelection(string[] lines, int min, int max, Action beforePrompt = null)
    {
        bool error = false;
        while (true)
        {
            Console.Clear();

            beforePrompt?.Invoke();
            
            foreach (var line in lines)
                Console.WriteLine(line);

            if (error)
            {
                Console.WriteLine();
                Console.WriteLine($"Invalid input. Enter a number between {min} and {max}.");
                Console.CursorTop-=2;
            }

            Console.Write("> ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int value) && value >= min && value <= max)
                return value;

            error = true;
            // Error displayed BELOW the user's input
        }
    }

    public static string GetString(string prompt, Action beforePrompt = null)
    {
        beforePrompt?.Invoke();

        Console.WriteLine(prompt);
        Console.Write("> ");
        return Console.ReadLine();
    }

    public static int GetInt(string prompt, int min = 0, int max = int.MaxValue, Action beforePrompt = null)
    {
        return GetMenuSelection([ prompt ], min, max, beforePrompt);
    }
}
