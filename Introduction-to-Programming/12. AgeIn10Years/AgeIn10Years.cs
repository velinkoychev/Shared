using System;

class AgeIn10Years
{
    static void Main()
    {
        Console.WriteLine("How old are you? Please enter the number of years and press enter");
        int v = int.Parse(Console.ReadLine()) + 10;
        Console.WriteLine("In 10 years time you will be " + v + " years old");
    }
}
