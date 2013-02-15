// Write a program to convert hexadecimal numbers to their decimal representation.


using System;
using System.Collections.Generic;

class HexadecimalToDecimal
{
    static void Main()
    {
        string hexadecimalNumber;
        Console.Write("Please, enter the hexadecimal number H (H>=0) = ");
        hexadecimalNumber = Console.ReadLine();
        if (hexadecimalNumber == "0") ////if the entered number is 0
        {
            Console.WriteLine("The decimal representation of this number is 0 ");
        }
        else
        {
            int decimalNumber = 0;
            int decimalDigit = 0;
            for (int i = hexadecimalNumber.Length - 1, power = 0; i >= 0; i--, power++)
            {
                decimalDigit = 0;
                switch (hexadecimalNumber[i])
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        decimalDigit = Convert.ToInt32(hexadecimalNumber[i])-48;
                        break;
                    case 'A':
                    case 'a':
                        decimalDigit = 10;
                        break;
                    case 'B':
                    case 'b':
                        decimalDigit = 11;
                        break;
                    case 'C':
                    case 'c':
                        decimalDigit = 12;
                        break;
                    case 'D':
                    case 'd':
                        decimalDigit = 13;
                        break;
                    case 'E':
                    case 'e':
                        decimalDigit = 14;
                        break;
                    case 'F':
                    case 'f':
                        decimalDigit = 15;
                        break;
                    default:
                        Console.WriteLine("You've entered a wrong number, sorry!");
                        break;
                }
                decimalNumber = decimalNumber + decimalDigit * (int)(Math.Pow(16, power));
            }


            Console.WriteLine("The decimal representation of this number is {0} ", decimalNumber);
        }
    }
}
