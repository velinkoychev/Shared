using System;
using System.Collections.Generic;

class BinaryToHexadecimal
{
    static void Main()
    {
        string binaryNumber;
        Console.Write("Please, enter the binary number H (H>=0) = ");
        binaryNumber = Console.ReadLine();
        if (binaryNumber == "0") ////if the entered number is 0
        {
            Console.WriteLine("The hexadecimal representation of this number is 0 ");
        }
        else
        {
            string binary4Digis = "";
            string hexadecimalNumber = "";
            //we will use switch cases for every 4 digits of the binary number
            for (int i = binaryNumber.Length - 1; i >= 0; i = i-4)
            {
                binary4Digis = "";
                for (int j = i; j > i - 4; j--)
                {
                    if (j >= 0)
                    {
                        binary4Digis = binaryNumber[j]+binary4Digis;
                    }
                }
                switch (binary4Digis.PadLeft(4, '0'))
                {
                    case "0000":
                        hexadecimalNumber = "0" + hexadecimalNumber;
                        break;
                    case "0001":
                        hexadecimalNumber = "1" + hexadecimalNumber;
                        break;
                    case "0010":
                        hexadecimalNumber = "2" + hexadecimalNumber;
                        break;
                    case "0011":
                        hexadecimalNumber = "3" + hexadecimalNumber;
                        break;
                    case "0100":
                        hexadecimalNumber = "4" + hexadecimalNumber;
                        break;
                    case "0101":
                        hexadecimalNumber = "5" + hexadecimalNumber;
                        break;
                    case "0110":
                        hexadecimalNumber = "6" + hexadecimalNumber;
                        break;
                    case "0111":
                        hexadecimalNumber = "7" + hexadecimalNumber;
                        break;
                    case "1000":
                        hexadecimalNumber = "8" + hexadecimalNumber;
                        break;
                    case "1001":
                        hexadecimalNumber = "9" + hexadecimalNumber;
                        break;
                    case "1010":
                        hexadecimalNumber = "A" + hexadecimalNumber;
                        break;
                    case "1011":
                        hexadecimalNumber = "B" + hexadecimalNumber;
                        break;
                    case "1100":
                        hexadecimalNumber = "C" + hexadecimalNumber;
                        break;
                    case "1101":
                        hexadecimalNumber = "D"+ hexadecimalNumber;
                        break;
                    case "1110":
                        hexadecimalNumber = "E" + hexadecimalNumber;
                        break;
                    case "1111":
                        hexadecimalNumber = "F" + hexadecimalNumber;
                        break;
                    default:
                        Console.WriteLine("You've entered a wrong number, sorry!");
                        break;
                }
            }


            Console.WriteLine("The hexadecimal representation of this number is {0} ", hexadecimalNumber);
        }
    }
}

