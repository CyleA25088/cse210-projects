using System.Runtime.InteropServices;

class BaseActivity
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration = 0;
    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public string GetName()
    {
        return _name;
    }

    protected void Spinner(int seconds)
    {
        const string animationString = "\\|/-";
        int sleepTime = 250;
        int duration = seconds;
        int index = 0;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);

        Console.CursorVisible = false;
        while(DateTime.Now < endTime)
        {
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }
        Console.CursorVisible = true;
    }

    protected void CountdownEvent(int seconds)
    {
        if(seconds>99)
            return;
    
        int duration = seconds;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);

        int count = duration;

        Console.CursorVisible = false;

        while(DateTime.Now < endTime)
        {
            Console.Write(count);
            Thread.Sleep(1000);
    
            if(count > 9)
                Console.Write("\b\b  \b\b");
            else
                Console.Write("\b");


            count--;
        }
        
        Console.CursorVisible = true;
    }

    public void DisplayTitleDescription()
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine(_description);

        Console.WriteLine();
    }

    public void ShowEndingMessage()
    {
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        
        Spinner(5);
    }

    public void AskForDuration()
    {
        Console.Write("How long, in seconds, would you like to participate in this activity?\n> ");

        int duration;
        string input = Console.ReadLine();

        while (!int.TryParse(input, out duration) || duration <= 0)
        {
            Console.WriteLine("Enter a positive number in seconds.");
            Console.Write("> ");
            input = Console.ReadLine();
        }

        _duration = duration;

        Console.Write("Get Ready! ");
        Spinner(5);

        Console.Clear();
    }

    virtual public void Run() { }
}