//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.


using System;
class PrintNumbers
{
    static void Main()
    {
        bool correctInput = false;
        decimal number = decimal.MinValue;
        while (!correctInput)
        {
            Console.Write("Please, enter your number = ");
            correctInput = decimal.TryParse(Console.ReadLine(), out number);
        }
        Console.WriteLine("As a decimal number:");
        Console.WriteLine("{0,15}", number);
        Console.WriteLine("As a hexadecimal number:");
        Console.WriteLine("{0,15:X}", (int)number);
        Console.WriteLine("As a percentage:");
        Console.WriteLine("{0,15:P}", number/100);
        Console.WriteLine("In scientific notation:");
        Console.WriteLine("{0,15:E}", number); 
    }
}

