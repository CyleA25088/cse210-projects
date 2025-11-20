class BreathingActivity : BaseActivity
{
    private int _inTime;
    private int _outTime;

    public BreathingActivity(int inTime, int outTime)
        : base("Breathing Activity")
    {
        _inTime = inTime;
        _outTime = outTime;

        _description = "This activity helps you practice controlled breathing.";
        _prompt = "How many seconds would you like to breathe for?";
    }

    public override void Run()
    {
        Console.WriteLine(_prompt);

        int breathingTime = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Get Ready!");
        CountdownEvent(5);

        DateTime endTime = DateTime.Now.AddSeconds(breathingTime);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in! ");
            CountdownEvent(_inTime);

            Console.WriteLine();

            Console.Write("Breathe out! ");
            CountdownEvent(_outTime);

            Console.WriteLine();
        }

        Console.WriteLine("Great Job!");
    }
}
