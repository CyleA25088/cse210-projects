class BaseActivity
{
    protected string _name = "";
    protected string _prompt = "";
    
    protected string _description = "";

    public BaseActivity(string name)
    {
        _name = name;
    }

    protected void Spinner(int seconds)
    {
        const string animationString = "\\|/-";
        int sleepTime = 250;
        int duration = seconds;
        int index = 0;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);

        while(DateTime.Now < endTime)
        {
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }
    }

    protected void CountdownEvent(int seconds)
    {
        if(seconds>99)
            return;

        int duration = seconds;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);

        int count = duration;

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
    }

    virtual public void Run() { }
}