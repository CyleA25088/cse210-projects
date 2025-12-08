using System;
using System.Collections.Generic;

class Program
{
    
    static List<Activity> activities = new List<Activity>();

    static private void GenerateActivities()
    {
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));
        activities.Add(new Cycling(new DateTime(2022, 11, 3), 30, 6.0));
        activities.Add(new Swimming(new DateTime(2022, 11, 3), 30, 40));}

    static void Main(string[] args)
    {
        GenerateActivities();

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
