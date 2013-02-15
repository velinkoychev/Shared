using System;
class CirclePerimeterAndArea
{
    static void Main()
    {
        double radius;
        Console.Write("Please, write radius r= ");
        radius = double.Parse(Console.ReadLine());
        Console.WriteLine("The perimeter of the circle = {0:0.00} and the area of the circle = {1:F2}", 2*Math.PI*radius, Math.PI*radius*radius);
    }
}

