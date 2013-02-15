// Write a program to convert binary numbers to their decimal representation.


using System;
using System.Collections.Generic;
class BinaryToDecimal
{
    static void Main()
    {
        int binaryNumber = 0;
        bool correctInput = false;
        while (!correctInput)
        {
            Console.Write("Please, enter the binary number = ");
            correctInput = int.TryParse(Console.ReadLine(), out binaryNumber);
        }
        if (binaryNumber == 0) ////if the entered number is 0
        {
            Console.WriteLine("The decimal representation of this number is 0 ");
        }
        else
        {
            int decimalNumber = 0;
            int counter = 0;
            while (binaryNumber > 0)
            {
                decimalNumber = decimalNumber + (binaryNumber % 10) * (int)Math.Pow(2, counter);
                counter++;
                binaryNumber = binaryNumber / 10;
            }

            Console.WriteLine("The decimal representation of this number is {0} ",decimalNumber);
        }
    }
}
