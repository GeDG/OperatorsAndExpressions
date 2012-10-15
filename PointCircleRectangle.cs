using System;

class PointCircleRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter x");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter y");
        double y = double.Parse(Console.ReadLine());
        bool check = false;
        if ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 9)
        {
            Console.WriteLine("Point is in K((1,1),3) !");
            if ((x > 5 || x < -1) || (y > 1 || y < -1))
            {
                check = true;
                Console.WriteLine("and out of R(1,-1,width=6,height=2) !");
                Console.WriteLine(check);
            }
            else
            {
                Console.WriteLine("and in the R");
                Console.WriteLine(check);
            }
        }
        else {
            Console.WriteLine("Point is out of the K((1,1),3)");
            Console.WriteLine(check);
        }
    }
}

