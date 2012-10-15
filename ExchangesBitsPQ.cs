using System;

class ExchangesBitsPQ
{
    static void Main()
    {
        Console.WriteLine("Enter number =");
        UInt32 number = UInt32.Parse(Console.ReadLine());
        Console.WriteLine("Before changes number = " + Convert.ToString(number, 2).PadLeft(32, '0'));
        
        Console.WriteLine("Enter position p = ");
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter position q = ");
        int q = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter bits k = ");
        int k = int.Parse(Console.ReadLine());
        int f, g;                    // help variables
        if (p + k - 1 >= q) {
            Console.WriteLine("p+k-1 must be < q to have exchanges");
            return;
        }
        for (int i = p; i < k; i++)
        {
            f = (int)((number & 1 << (p + i)) >> (p + i));
            g = (int)((number & 1 << (q + i)) >> (q + i));
            if (f == 1)
            {
                number = (UInt32)(number | f << (q + i));
            }
            else if (f == 0)
            {
                number = (UInt32)(number ^ f << (q + i));
                if ((number & 1 << (q + i)) >> (q + i) == 1)
                {
                    f = 1;
                    number = (UInt32)(number ^ f << (q + i));
                }
            }
            if (g == 1)
            {
                number = (UInt32)(number | g << (p + i));
            }
            else if (g == 0)
            {
                number = (UInt32)(number ^ g << (p + i));
                if ((number & 1 << (p + i)) >> (p + i) == 1)
                {
                    g = 1;
                    number = (UInt32)(number ^ g << (p + i));
                }
            }
        }
        Console.WriteLine("After  changes number = " + Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}

