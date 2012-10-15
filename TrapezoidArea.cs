using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Enter side a");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side b");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter h");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("Trapezoid`s Area = " + (a + b) * h / 2); 
    }
}

