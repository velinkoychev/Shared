using System;

class TrapezoidArea
{
    static void Main()
    {
        double sideA, sideB, heightH, trapezoidArea;
        Console.WriteLine("side a =");
        sideA = double.Parse(Console.ReadLine());
        Console.WriteLine("side b =");
        sideB = double.Parse(Console.ReadLine());
        Console.WriteLine("height =");
        heightH = double.Parse(Console.ReadLine());
        trapezoidArea = (sideA + sideB) / 2 * heightH;
        Console.WriteLine("The area of the trapezoid is " + trapezoidArea );
    }
}

