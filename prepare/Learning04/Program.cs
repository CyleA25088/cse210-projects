using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Bob Douglas", "What is DNA");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Bob Dilly", "Fractions", "1.1", "1-20");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Bob Striker", "History", "The Holodomor");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}