// Write a program to convert decimal numbers to their hexadecimal representation.


using System;
using System.Collections.Generic;

class DecimalToHexadecimal
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
            Console.WriteLine("The hexadecimal representation of this number is 0 ");
        }
        else
        {
            List<string> hexadecimalNumber = new List<string>(); //// create a List to save the digits of the hexadecimal representation
            string stringDigit="";
            while (decimalNumber > 0)
            {
                int hexadecimalDigit = decimalNumber % 16;
                switch (hexadecimalDigit)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        stringDigit = Convert.ToString(hexadecimalDigit);
                        break;
                    case 10: stringDigit = "A";
                        break;
                    case 11: stringDigit = "B";
                        break;
                    case 12: stringDigit = "C";
                        break;
                    case 13: stringDigit = "D";
                        break;
                    case 14: stringDigit = "E";
                        break;
                    case 15: stringDigit = "F";
                        break;
                }
                hexadecimalNumber.Add(stringDigit);
                decimalNumber = decimalNumber / 16;
            }
            hexadecimalNumber.Reverse();
            Console.Write("The hexadecimal representation of this number is  ");
            for (int i = 0; i < hexadecimalNumber.Count; i++)
            {
                Console.Write(hexadecimalNumber[i]);
            }
            Console.WriteLine();
        }

    }

}


