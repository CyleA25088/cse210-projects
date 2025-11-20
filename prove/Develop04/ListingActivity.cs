class ListingActivity : BaseActivity
{
    private List<string> _questions = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];
    private static Random _rand = new Random();

    public ListingActivity()
        : base("Listing Activity", "This activity will help you reflect on the good\nthings in your life by having you list as many things as you can in a certain area.")
    {
        
    }

    public override void Run()
    {
        Console.Clear();
        Console.WriteLine("List as many responces you can to the following prompt:\n");        
        string prompt = _questions[_rand.Next(_questions.Count)];
        Console.WriteLine($" --- {prompt} ---\n");

        Console.Write("You may begin in: ");
        
        CountdownEvent(5);
        Console.WriteLine();


        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        // Console.WriteLine("\nStart listing items! Press Enter after each one.");

        // 4. Collect items
        List<string> items = new List<string>();
            
        Console.Write("> ");
        
        while (DateTime.Now < endTime)
        {
            // Keep reading lines until time is up
            if (Console.KeyAvailable)
            {
                string item = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(item))
                    items.Add(item);
                
                Console.Write("> ");
            }
        
            Thread.Sleep(50); // prevents CPU from dying
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
    }

}
