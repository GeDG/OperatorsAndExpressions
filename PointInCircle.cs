using System;

class PointInCircle
{
    static void Main()
    {
        Console.WriteLine("Enter x");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter y");
        double y = double.Parse(Console.ReadLine());
        if (x * x + y * y <= 25) 
            Console.WriteLine("Point is in circle with K(0,5)");
        else
            Console.WriteLine("Point is out of the circle K(0,5)");
    }
}

