using System;

class Program
{
    static void Main(string[] args)
    {
        string firstName;
        string lastName;

        Console.Write("Please Input your first name: ");
        firstName = Console.ReadLine();

        Console.Write("Please Input your last name: ");
        lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
}