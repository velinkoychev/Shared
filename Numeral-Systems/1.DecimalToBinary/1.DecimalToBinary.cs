// Write a program to convert decimal numbers to their binary representation.


using System;
using System.Collections.Generic;
class DecimalToBinary
{
    static void Main()
    {
        int decimalNumber = 0;
        bool correctInput = false;
        while (!correctInput)
        {
            Console.Write("Please, enter the decimal number N (N>=0) = ");
            correctInput = int.TryParse(Console.ReadLine(), out decimalNumber);
        }
        if (decimalNumber == 0) ////if the entered number is 0
        {
            Console.WriteLine("The binary representation of this number is 0 ");
        }
        else
        {
            List<int> binaryNumber = new List<int>(); //// create a List to save the digits of the binary representation
            while (decimalNumber > 0)
            {
                binaryNumber.Add(decimalNumber % 2);
                decimalNumber = decimalNumber / 2;
            }
            binaryNumber.Reverse();
            Console.Write("The binary representation of this number is  ");
            for (int i = 0; i < binaryNumber.Count; i++)
            {
                Console.Write(binaryNumber[i]);
            }
            Console.WriteLine();
        }

    }

}
