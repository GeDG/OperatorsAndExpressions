using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        if ((number & 1 << 0) >> 0 == 1)
        {
            Console.WriteLine("odd");
        }
        else {
            Console.WriteLine("even");
        }

    }
}

