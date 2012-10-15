using System;


class CheckBitValue
{
    static void Main()
    {
        Console.WriteLine("Enter number i = ");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position b = ");
        int b = int.Parse(Console.ReadLine());
        int k = (i & 1 << b) >> b;
        Console.WriteLine("value = " + k);
    }
}

