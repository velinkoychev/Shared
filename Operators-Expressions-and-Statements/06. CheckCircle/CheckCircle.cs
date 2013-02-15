using System;

class CheckCircle
{
    static void Main()
    {
        double x, y, radius;
        Console.WriteLine("Write the value of X...");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Write the value of Y...");
        y = double.Parse(Console.ReadLine()); 
        radius = Math.Sqrt(x * x + y * y); //Calculate the distance from the center of the circle
        bool inOrOutOfCircle = (radius <=5);
        Console.WriteLine(inOrOutOfCircle ? "It is in the circle" : "It is not in the circle");
    }
}

