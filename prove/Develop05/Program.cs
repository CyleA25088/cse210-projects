class Program
{
    private static readonly List<BaseGoal> _goals = new();
    private static int _points = 0;

    // ------------------------------
    // LIST GOALS
    // ------------------------------
    static void ListGoals()
    {
        Console.WriteLine("Goals:");

        if (_goals.Count == 0)
        {
            Console.WriteLine("  No goals available.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].DisplayGoal();
        }
    }

    // ------------------------------
    // SAVE GOALS
    // ------------------------------
    static void SaveGoals()
    {
        using StreamWriter outputFile = new("goals.txt");

        outputFile.WriteLine($"Points|{_points}");

        foreach (var goal in _goals)
        {
            outputFile.WriteLine(goal.Serialize());
        }
    }

    // ------------------------------
    // LOAD GOALS
    // ------------------------------
    
    static void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        _goals.Clear();

        string[] lines = System.IO.File.ReadAllLines("goals.txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string typeOf = parts[0];
            
            if(typeOf == "Points")
            {
                _points = int.Parse(parts[1]);
                continue;
            }
            
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            switch (typeOf)
            {
                case "SimpleGoal":
                    bool isCompleted = parts[4] == "1";
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    if (isCompleted)
                        simpleGoal.MarkCompleted();
                    _goals.Add(simpleGoal);
                    break;

                case "EternalGoal":
                    int timesCompleted = int.Parse(parts[4]);// timesCompleted
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);

                    eternalGoal.SetTimesCompleted(timesCompleted);

                    _goals.Add(eternalGoal);
                    break;

                case "ChecklistGoal":
                    int currentCount = int.Parse(parts[4]);// currentCount
                    int targetCount = int.Parse(parts[5]); // targetCount
                    int bonusPoints = int.Parse(parts[6]); // bonusPoints

                    CheckListGoal checklistGoal = new CheckListGoal(name, description, points, targetCount, bonusPoints);

                    checklistGoal.SetCurrentCount(currentCount);
                    _goals.Add(checklistGoal);
                    break;
            }
        }
    }

    // ------------------------------
    // RECORD EVENT
    // ------------------------------
    static void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record. Please create a goal first.");
            return;
        }

        int index = InputHandler.GetInt(
            "Select the goal number to record an event for",
            0, _goals.Count,
            ListGoals
        ) - 1;

        if(index == -1)
        {
            Console.WriteLine("No Goal Recorded.");
            return;
        }

        BaseGoal goal = _goals[index];
        int earned = goal.RecordEvent();
        _points += earned;

        Console.WriteLine(
            earned > 0
            ? $"Congratulations! You earned {earned} points."
            : "This goal has already been completed."
        );
    }

    static void getPointsDisplay()
    {
        if (_points == 1)
        {
            Console.WriteLine($"You have {_points} point.\n");
            return;
        }

        Console.WriteLine($"You have {_points} points.\n");
    }

    // ------------------------------
    // MAIN MENU LOOP
    // ------------------------------
    static void Main(string[] args)
    {
        while (true)
        {
            int option = InputHandler.GetMenuSelection(
                new[]
                {
                    "Menu Options:",
                    "1. Create New Goal",
                    "2. List Goals",
                    "3. Save Goals",
                    "4. Load Goals",
                    "5. Record Event",
                    "6. Quit"
                },
                1, 6, getPointsDisplay
            );

            Console.Clear();

            switch (option)
            {
                case 1:
                    CreateGoal();
                    break;

                case 2:
                    ListGoals();
                    Pause();
                    break;

                case 3:
                    SaveGoals();
        
                    Console.WriteLine("Saved goals.");
        
                    Pause();
                    break;

                case 4:
                    LoadGoals();
                    
                    Console.WriteLine($"Successfully loaded {_goals.Count} goals.");
                    getPointsDisplay();
                    
                    Pause();
                    break;

                case 5:
                    RecordEvent();
                    Pause();
                    break;

                case 6:
                    return;
            }
        }
    }

    private static void Pause()
    {
        Console.WriteLine("\nPress ENTER to continue...");
        Console.ReadLine();
    }

    // ------------------------------
    // CREATE GOAL
    // ------------------------------
    static void CreateGoal()
    {
        int type = InputHandler.GetMenuSelection(
            new[]
            {
                "Select the type of goal to create:",
                "1. Simple Goal",
                "2. Eternal Goal",
                "3. Checklist Goal"
            },
            1, 3
        );

        Console.Clear();
        string name = InputHandler.GetString("Goal Name:");

        void printName() => Console.WriteLine(name);

        Console.Clear();
        string description = InputHandler.GetString("Description:", printName);

        Console.Clear();
        int points = InputHandler.GetInt("Points:", 1, 1000, printName);

        switch (type)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points));
                break;

            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;

            case 3:
                int targetCount = InputHandler.GetInt($"{name}\nHow many times to complete?");
                int bonusPoints = InputHandler.GetInt($"{name}\nBonus points for completing:");
                _goals.Add(new CheckListGoal(name, description, points, targetCount, bonusPoints));
                break;
        }
    }
}
