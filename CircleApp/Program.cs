using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World");

        Circle myCircle = new Circle();

        myCircle.SetRadius(20);

        Console.WriteLine(myCircle.GetCircleArea());
    }
}