using System;

class ModifiesBits
{
    static void Main()
    {
        Console.WriteLine("Enter number n = ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("n = " + Convert.ToString(n, 2).PadLeft(10, '0'));

        Console.WriteLine("Enter position p =");
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter value = ");
        int value = int.Parse(Console.ReadLine());
        if (value == 1)
        {
            n = (n | value << p);
        }
        else if (value == 0) {
            n = (n ^ (value << p));
            if ((n & 1 << p) >> p == 1)
            {
                value = 1;
                n = (n ^ (value << p));
            }
        }
        Console.WriteLine("n = " + Convert.ToString(n, 2).PadLeft(10,'0'));
    }
}

