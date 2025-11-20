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

        int total = seconds * 2;

        Console.Write("[");
        int innerStart = Console.CursorLeft;
        Console.Write(new string(' ', total));
        Console.Write("]");

        Console.SetCursorPosition(innerStart, Console.CursorTop);

        for (int i = 0; i < total; i++)
        {
            Thread.Sleep(500);
            Console.Write("#");
        }

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
