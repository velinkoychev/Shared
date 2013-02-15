using System;

class Read3Integers
{
    static void Main()
    {
        int number1, number2, number3;
        Console.Write("Please write integer number 1= ");
        number1 = int.Parse(Console.ReadLine());
        Console.Write("Please write integer number 2= ");
        number2 = int.Parse(Console.ReadLine());
        Console.Write("Please write integer number 3= ");
        number3 = int.Parse(Console.ReadLine());
        Console.WriteLine("The sum of the three number = {0}", number1 + number2 + number3);
    }
}

