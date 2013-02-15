//Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".


using System;
class ReadTheLastDigitMethod
{
    static string ReadTheLastDigit(int numberToRead)
    {
        int digitToRead = Math.Abs(numberToRead % 10);  ////we want to make sure that the program will work also with negative numbers
        string lastDigit = "";
        switch (digitToRead)
        {
            case 0: lastDigit = "Zero"; break;
            case 1: lastDigit = "One"; break;  
            case 2: lastDigit = "Two"; break;
            case 3: lastDigit = "Three"; break;
            case 4: lastDigit = "Four"; break;
            case 5: lastDigit = "Five"; break;
            case 6: lastDigit = "Six"; break;
            case 7: lastDigit = "Seven"; break;
            case 8: lastDigit = "Eight"; break;
            case 9: lastDigit = "Nine"; break;
            default: Console.WriteLine("Sorry, you have made a mistake!");  break;
        }
        return lastDigit;
    }

    static int ReadIntegerNumber()
    {
        int integerNumber = int.MinValue;
        bool correctInput = false;
        while (!correctInput)
        {
            Console.Write("Please, enter integer number =");
            correctInput = int.TryParse(Console.ReadLine(), out integerNumber);
        }
        return integerNumber;
    }
    static void Main()
    {
        string lastDigit = ReadTheLastDigit(ReadIntegerNumber());
        Console.WriteLine("The last digit is {0}", lastDigit);
    }
}

