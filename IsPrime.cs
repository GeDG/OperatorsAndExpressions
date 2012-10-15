using System;

class IsPrime
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        bool check = true;
        for (int i = 2; i < Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                check = false;
                Console.WriteLine("number is not a prime");
                break;
            }
            
        }
        if (check) {
            Console.WriteLine("number is a prime");
        }
    }
}

