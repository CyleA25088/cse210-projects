using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.WriteLine(Math.Pow(2, 10));
        int x = 10;
        Console.WriteLine($"{x}, {++x}, {x++}, {x}");

        for (int i = -1000; i < 1000; i += 10)
        {
            Console.WriteLine($"The value of i is: {i}");
        }
    }
}