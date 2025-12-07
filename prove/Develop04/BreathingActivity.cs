class BreathingActivity : BaseActivity
{
    private int _inTime;
    private int _outTime;

    public BreathingActivity(int inTime, int outTime)
        : base("Breathing Activity", "This activity will help you relax by walking you\nthrough breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        _inTime = inTime;
        _outTime = outTime;
    }
        
    private void BreathingProgressBar(int seconds)
    {
        Console.CursorVisible = false;

        int barWidth = seconds * 5;
        int totalSteps = seconds * 10;

        Console.Write("\n[");
        int innerStart = Console.CursorLeft;
        Console.Write(new string(' ', barWidth));
        Console.Write("]");

        Console.SetCursorPosition(innerStart, Console.CursorTop);

        for (int i = 0; i < totalSteps; i++)
        {
            // Ease-out curve
            double t = (double)i / totalSteps;
            double eased = 1 - Math.Pow(1 - t, 3);

            int charsToShow = (int)(eased * barWidth);

            Console.SetCursorPosition(innerStart, Console.CursorTop);
            Console.Write(new string('#', charsToShow));
            Console.Write(new string(' ', barWidth - charsToShow));

            Thread.Sleep(100);
        }

        Console.SetCursorPosition(innerStart, Console.CursorTop);
        Console.Write(new string('#', barWidth));

        Console.WriteLine();
        Console.CursorVisible = true;
    }




    public override void Run()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.Clear();

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in!  ");
            BreathingProgressBar(_inTime);

            Console.Write("Breathe out! ");
            BreathingProgressBar(_outTime);
        }

        Console.WriteLine("Well done!");
    }
}
