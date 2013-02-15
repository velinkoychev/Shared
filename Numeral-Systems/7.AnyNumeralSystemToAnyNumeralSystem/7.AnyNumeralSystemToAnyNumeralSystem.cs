//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).


using System;
using System.Collections.Generic;

class AnyNumeralSystemToAnyNumeralSystem
{
    static int BaseStoDecimal(string baseSNumber,int baseS) //// convert the number from base S numeral system to decimal
    {
        int decimalDigit = 0;
        int decimalNumber = 0;    
        //we will use switch cases for every digit of the base S number
        for (int i = baseSNumber.Length - 1, power=0; i >= 0; i--, power ++)
        {
            decimalDigit = 0;
            switch (baseSNumber[i])
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
                    decimalDigit = Convert.ToInt32 (baseSNumber[i])-48;
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
            decimalNumber = decimalNumber + decimalDigit * (int) Math.Pow(baseS, power);
        }
        return decimalNumber;
    }

    static List<string> decimalToBaseD(int decimalNumber, int baseD) //// convert the number from decimal to base D numeral system
    {
        List<string> baseDNumber = new List<string>(); //// create a List to save the digits of the base D  representation
        string stringDigit = "";
        while (decimalNumber > 0)
        {
            int baseDDigit = decimalNumber % baseD;
            switch (baseDDigit)
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
                    stringDigit = Convert.ToString(baseDDigit);
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
            baseDNumber.Add(stringDigit);
            decimalNumber = decimalNumber / baseD;
        }
        baseDNumber.Reverse();
        return baseDNumber;
    }
    static void Main()
    {
        int baseS = 0;
        int baseD = 0;
        bool correctInput = false;
        while (!correctInput)
        {
            Console.Write("Please, enter base S = ");
            correctInput = int.TryParse(Console.ReadLine(), out baseS);
        }
        correctInput = false;
        while (!correctInput)
        {
            Console.Write("Please, enter base D = ");
            correctInput = int.TryParse(Console.ReadLine(), out baseD);
        }
        string baseSNumber;
        Console.Write("Please, enter the base S number H (H>=0) = ");
        baseSNumber = Console.ReadLine();
        if (baseSNumber == "0")
        {
            Console.WriteLine("The base {0} representation of this number is 0 ", baseD);
        }
        int decimalRepresentation = BaseStoDecimal(baseSNumber, baseS);
        List<string> baseDRepresentation = decimalToBaseD(decimalRepresentation, baseD);
        Console.WriteLine("The base {0} representation of this number is ", baseD);
        for (int i = 0; i < baseDRepresentation.Count; i++)
        {
            Console.Write("{0}", baseDRepresentation[i]);
        }
        Console.WriteLine();
    }
}
