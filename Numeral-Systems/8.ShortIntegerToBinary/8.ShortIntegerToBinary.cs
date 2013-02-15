//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).


using System;
using System.Collections.Generic;
class ShortIntegerToBinary
{
    static void Main()
    {
        int decimalNumber = 0;
        bool correctInput = false;
        while (!correctInput)
        {
            Console.Write("Please, enter the short integer number N = ");
            correctInput = int.TryParse(Console.ReadLine(), out decimalNumber);
        }
        if (decimalNumber == 0) ////if the entered number is 0
        {
            Console.WriteLine("The binary representation of this number is 0 ");
        }
        else
        {
            int negativeDecimalNumber = 0; //// if the number is positive, we will store 0, if it is negative - we will store 1
            if (decimalNumber < 0)
            {   
                decimalNumber = (int)Math.Pow(2, 15) + decimalNumber;  ////use this formula to calculate easier 
                negativeDecimalNumber = 1;
            }
            string binaryNumber = "";
            while (decimalNumber > 0)
            {
                binaryNumber = decimalNumber % 2 + binaryNumber; ;
                decimalNumber = decimalNumber / 2;
            }

            Console.WriteLine("The binary representation of this number is  {0}{1}", negativeDecimalNumber, binaryNumber.PadLeft(15, '0'));
        }

    }

}
