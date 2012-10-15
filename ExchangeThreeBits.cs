using System;

class ExchangeThreeBits
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        UInt32 number = UInt32.Parse(Console.ReadLine());
        Console.WriteLine("Before changes number = "+ Convert.ToString(number,2).PadLeft(32,'0'));
        int k,z;                                        // help variables
        for (int i = -1; i < 2; i++)
        {
            k = (int)((number & 1 << (3 + i)) >> (3 + i));
            z = (int)((number & 1 << (24 + i)) >> (24 + i));
            if (k == 1)
            {
                number = (UInt32)(number | k << (24 + i));
            }
            else if (k == 0)
            {
                number = (UInt32)(number ^ k << (24 + i));
                if ((number & 1 << (24 + i)) >> (24 + i) == 1)
                {
                    k = 1;
                    number = (UInt32)(number ^ k << (24 + i));
                }
            }
            if (z == 1)
            {
                number = (UInt32)(number | z << (3 + i));
            }
            else if (z == 0)
            {
                number = (UInt32)(number ^ z << (3 + i));
                if ((number & 1 << (3 + i)) >> (3 + i) == 1)
                {
                    z = 1;
                    number = (UInt32)(number ^ z << (3 + i));
                }
            }
        }
        Console.WriteLine("After  changes number = " + Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}

