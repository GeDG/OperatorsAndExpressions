using System;

class RectangleArea
{
    static void Main()
    {
        Console.WriteLine("Enter width");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("Rectangle`s area = " + width * height) ;
    }
}

