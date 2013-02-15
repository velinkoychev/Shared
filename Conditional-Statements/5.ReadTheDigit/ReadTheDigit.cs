using System;
class ReadTheDigit
{
    static void Main()
    {
        string readTheDigit = "";
        byte digit;
        Console.WriteLine("Please, write a digit [0...9]");
        digit = byte.Parse(Console.ReadLine());
        switch (digit)
        {
            case 0:
                readTheDigit = "zero";
                break;
            case 1:
                readTheDigit = "one";
                break;
            case 2:
                readTheDigit = "two";
                break;
            case 3:
                readTheDigit = "three";
                break;
            case 4:
                readTheDigit = "four";
                break;
            case 5:
                readTheDigit = "five";
                break;
            case 6:
                readTheDigit = "six";
                break;
            case 7:
                readTheDigit = "seven";
                break;
            case 8:
                readTheDigit = "eight";
                break;
            case 9:
                readTheDigit = "nine";
                break;
            default :
                Console.WriteLine("You have entered a wrong digit");
                break;
        }
        if ((digit >= 0) && (digit < 10))
        {
            Console.WriteLine("You have enter the digit {0}, which in English is {1}", digit, readTheDigit);
        }
    }
}

