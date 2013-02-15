using System;
class RectangleArea
{
    static void Main()
    {
        double width, height, area;
        Console.WriteLine("Write the width");
        double.TryParse(Console.ReadLine(), out width); // checking if the entered value is correct
        Console.WriteLine("Write the height");
        double.TryParse(Console.ReadLine(), out height);
        area = width * height;
        Console.WriteLine("Area = " + area);
    }
}
