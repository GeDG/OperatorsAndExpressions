using System;

class FindingTheThirdBit
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number,2)+" - our number");
        if ((number & 1 << 2) >> 2 == 1)
        {
            Console.WriteLine("Third bit is 1");
        }
        else {
            Console.WriteLine("Third bit is 0");
        }
    }
}

