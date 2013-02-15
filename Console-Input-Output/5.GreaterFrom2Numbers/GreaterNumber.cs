using System;

class GreaterNumber
{
    static void Main()
    {
        decimal number1, number2;
        Console.Write("Write the first number... ");
        number1 = decimal.Parse(Console.ReadLine());
        Console.Write("Write the second number... ");
        number2 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("The greater number is {0}", ((Math.Abs(number1-number2)+number1+number2)/2));
    }
}
