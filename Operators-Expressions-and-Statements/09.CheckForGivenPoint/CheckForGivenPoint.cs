using System;
class CheckForGivenPoint
{
    static void Main()
    {
        double xCoordinate, yCoordinate, radius;
        Console.WriteLine("Write the value of X...");
        xCoordinate = double.Parse(Console.ReadLine());
        Console.WriteLine("Write the value of Y...");
        yCoordinate = double.Parse(Console.ReadLine());
        radius = Math.Sqrt((xCoordinate - 1)*(xCoordinate - 1) + (yCoordinate - 1)*(yCoordinate - 1));
        //Calculate the distance from the center of the circle. We add +1 in order to locate the center of the
        //coordinate system in the center of the circle
        bool inCircle = (radius <= 3); // check if it is in the circle
        bool outOfRectangle;
        outOfRectangle = !(((xCoordinate <= 5) && (xCoordinate >= -1)) && ((yCoordinate <= 1) && (yCoordinate >= -1)));
        Console.WriteLine(inCircle&&outOfRectangle ? "The given point is where it should be" : "The given point is not where it should be" );
    }
}

