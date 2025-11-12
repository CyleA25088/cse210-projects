using System;

public class Program
{
    private static Scripture _scripture;
    private static readonly string _verse = "Thou shalt not hate thy brother in thine heart: thou shalt in any wise rebuke thy neighbour, and not suffer sin upon him. Thou shalt not avenge, nor bear any grudge against the children of thy people, but thou shalt love thy neighbour as thyself: I am the Lord.";

    public static void Main(string[] args)
    {
        Reference reference = new Reference("Leviticus", 19, 17, 18);
        _scripture = new Scripture(reference, _verse);
     
        bool notFinished = true;
        while (notFinished)
        {
            if (Run())
                break;
        }
    }

    private static bool Run()
    {
        Console.Clear();
        
        Display();

        if (_scripture.IsCompletelyHidden())
            return true;

        string userInput = Console.ReadLine();
        if (userInput.ToLower() == "quit")
            return true;
        
        _scripture.HideRandomWords(3);

        return false;    
    }

    private static void Display()
    {
        Console.WriteLine(_scripture.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
    }
}
