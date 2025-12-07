using System;

class Program
{
    static List<BaseActivity> _activities = new List<BaseActivity>
    {
        new BreathingActivity(5,5),
        new ReflectionActivity(),
        new ListingActivity(),
    };

    static void Main(string[] args)
    {
        while (true) {
            int input = -1;
            do {
                Console.Clear();
                DisplayMenu();

                string userInput = Console.ReadLine();

                if (!int.TryParse(userInput, out input))
                {
                    input = -1;
                    continue;
                }
                
            } while (input < 0 || input > _activities.Count);

            // user Quits the program
            if (input == 0) return;

            int activityIndex = input - 1;
            BaseActivity chosenActivity = _activities[activityIndex];

            Console.Clear();
            chosenActivity.DisplayTitleDescription();
            chosenActivity.AskForDuration();

            chosenActivity.Run();

            chosenActivity.ShowEndingMessage();
        }
    }

    static private void DisplayMenu()
    {
        Console.WriteLine("Menu Options");
        int index = 0;
        Console.WriteLine($"  {index++}. Quit");
        foreach (BaseActivity activity in _activities)
        {
            Console.WriteLine($"  {index++}. {activity.GetName()}");
        }
        Console.Write("Select a choice from the menu\n> ");
    }
}