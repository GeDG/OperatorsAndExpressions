using System;

class ChecksBit
{
    static void Main()
    {
        Console.WriteLine("Enter number v");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position p");
        int p = int.Parse(Console.ReadLine());
        bool check = true;
        if ((v & 1 << p) >> p == 1)
        {
            Console.WriteLine("Bit at position p is 1");
            Console.WriteLine(check);
        }
        else {
            Console.WriteLine("Bit at position p is 0");
            Console.WriteLine(!check);
        }

    }
}

