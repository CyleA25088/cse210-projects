using System;

namespace CircleApp;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello world!");
        Circle myCircle = new Circle();
        Console.WriteLine(myCircle.GetArea());
        Circle myCircle2 = new Circle(20);
        Console.WriteLine(myCircle2.GetArea());
        Console.WriteLine(myCircle2.GetCircumference());
        Console.WriteLine(myCircle2.GetDiameter());

        List<Circle> circles = new List<Circle>();

        circles.Add(myCircle);
        circles.Add(myCircle2);

        foreach (Circle C in circles)
        {
            Console.WriteLine(C.GetArea());
        }

    }
}