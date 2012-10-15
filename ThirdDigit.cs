using System;

class ThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        bool check = false;
        if (number < 1000 && number > 99)
        {
            if (number / 100 == 7)
            {
                check = true;
                Console.WriteLine(check);
            }
            else
                Console.WriteLine(check);
        }
        else if (number > 999) {
            number = number % 1000;
            if (number / 100 == 7) {
                check = true;
                Console.WriteLine(check);
            }
            else
                Console.WriteLine(check);
        }
        else
            Console.WriteLine("Error! Enter another number!");
    }
}

