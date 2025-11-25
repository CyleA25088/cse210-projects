class Program
{
    static void PassReferneceType(int [] data)
    {
        data[3] = 12345;
        Console.WriteLine($"In the PassReferneceType, data[3] is: {data[3]}");

    }

    static void PassByOut(out int z){
        z = 17;        
        Console.WriteLine($"In the PassByOut funcion, x is: {z}");
    }

    static void PassByReference(ref int x)
    {
        x = 3002;
        Console.WriteLine($"In the reference funcion, x is: {x}");
    }

    static void PassByValue(int x)
    {
        x = 1001;
        Console.WriteLine($"In the value funcion, x is: {x}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("hello world");

        int x = 10;
        int y = x;
        
        x += 3;
        y += 1;

        Console.WriteLine($"{x} {y}");


        int[] a = { 1, 2, 3, 4, 5 };
        int[] b = a;

        b[3] = 111;

        Console.WriteLine($"{a[3]} {b[3]}");
    
        PassByValue(x);
        Console.WriteLine($"In main, x is: {x}");
    
        PassByReference(ref x);
        Console.WriteLine($"In main, x is: {x}");

        int z;
        PassByOut(out z);
        Console.WriteLine($"In main, z is: {z}");

        PassReferneceType(a);
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine($"In main, a[{i}] = {a[i]}");
        }

    }
}