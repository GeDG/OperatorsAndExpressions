using System;

class DividedFiveAndSeven
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        if (number % 5 == 0 && number % 7 == 0)
        {
            Console.WriteLine("can be divided");
        }
        else {
            Console.WriteLine("cant be divided");
        }
    }
}

