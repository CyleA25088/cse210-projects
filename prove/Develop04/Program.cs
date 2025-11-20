using System;

class Program
{
List<BaseActivity> activities = new List<BaseActivity>
{
    new BreathingActivity(4,5),
    // new ReflectionActivity("...", "Reflection", 8),
    // new ListingActivity("...", "Listing", 12)
};


    static void Main(string[] args)
    {



        Console.WriteLine("Hello Develop04 World!");

        BreathingActivity myBreathingActivity = new BreathingActivity(4,5);

        myBreathingActivity.Run();
    }

    private void ProcessMenu()
    {
        Console.WriteLine("Menu Options");
        
    }
}