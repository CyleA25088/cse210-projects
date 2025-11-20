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
        Console.Write("[");
        Console.Write(new string(' ', seconds*2));
        Console.Write("]");
        Console.Write(new string('\b', seconds*2+1));

        for (int i = 1; i <= seconds*2; i++)
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
