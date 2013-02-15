//Write a program to convert hexadecimal numbers to binary numbers (directly).


using System;
using System.Collections.Generic;

class HexadecimalToBinary
{
    static void Main()
    {
        string hexadecimalNumber;
        Console.Write("Please, enter the hexadecimal number H (H>=0) = ");
        hexadecimalNumber = Console.ReadLine();
        if (hexadecimalNumber == "0") ////if the entered number is 0
        {
            Console.WriteLine("The binary representation of this number is 0 ");
        }
        else
        {
            string binaryNumber = "";
            //we will use switch cases for every digit of the hexadecimal number
            for (int i = 0; i < hexadecimalNumber.Length; i++)
            {
                switch (hexadecimalNumber[i])
                {
                    case '0': 
                        binaryNumber += "0000"; 
                        break;
                    case '1':
                        binaryNumber += "0001"; 
                        break;
                    case '2':
                        binaryNumber += "0010"; 
                        break;
                    case '3':
                        binaryNumber += "0011"; 
                        break;
                    case '4':
                        binaryNumber += "0100"; 
                        break;
                    case '5':
                        binaryNumber += "0101"; 
                        break;
                    case '6':
                        binaryNumber += "0110"; 
                        break;
                    case '7':
                        binaryNumber += "0111"; 
                        break;
                    case '8':
                        binaryNumber += "1000"; 
                        break;
                    case '9':
                        binaryNumber += "1001"; 
                        break;
                    case 'A':
                    case 'a':
                        binaryNumber += "1010"; 
                        break;
                    case 'B':
                    case 'b':
                        binaryNumber += "1011"; 
                        break;
                    case 'C':
                    case 'c':
                        binaryNumber += "1100"; 
                        break;
                    case 'D':
                    case 'd':
                        binaryNumber += "1101"; 
                        break;
                    case 'E':
                    case 'e':
                        binaryNumber += "1110"; 
                        break;
                    case 'F':
                    case 'f':
                        binaryNumber += "1111"; 
                        break;
                    default:
                        Console.WriteLine("You've entered a wrong number, sorry!");
                        break;
                }
            }


            Console.WriteLine("The binary representation of this number is {0} ", binaryNumber);
        }
    }
}
