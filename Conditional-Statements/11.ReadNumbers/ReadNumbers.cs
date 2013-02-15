using System;
class ReadNumbers
{
    static int numberToRead;
    static string readTheHundreds;
    static string readUnusualNumberEndings; // if the last to digits of the numbers are [0..19] 
    static string readTheSecondDigit;
    static string readTheLastDigit;

    static void ReadTheNumber()
    {
        Console.WriteLine("Please, enter the number that you want to read in the range [0...999] ");
        do
        {
            bool numberIsCorrect = int.TryParse(Console.ReadLine(), out numberToRead);
            if ((numberToRead > 999) || (numberToRead < 0))
            {
                Console.WriteLine("You have entered a wrong number, please enter a new one");
            }
        }
        while ((numberToRead > 999) || (numberToRead < 0));
    }

    static void ReadTheHundreds()
    {
        int numberOfHundreds;
        numberOfHundreds = numberToRead / 100;
        switch (numberOfHundreds)
        {
            case 1:
                readTheHundreds = "one hundred";
                break;
            case 2:
                readTheHundreds = "two hundred";
                break;
            case 3:
                readTheHundreds = "three hundred";
                break;
            case 4:
                readTheHundreds = "four hundred";
                break;
            case 5:
                readTheHundreds = "five hundred";
                break;
            case 6:
                readTheHundreds = "six hundred";
                break;
            case 7:
                readTheHundreds = "seven hundred";
                break;
            case 8:
                readTheHundreds = "eight hundred";
                break;
            case 9:
                readTheHundreds = "nine hundred";
                break;
            default:
                Console.WriteLine("there is an error");
                break;
        }
    }
    static void ReadSecondAndThirdDigits()
    {
        int digitOfTenths;
        int lastDigit;
        digitOfTenths = (numberToRead % 100) / 10;
        lastDigit = (numberToRead % 10);
        switch (digitOfTenths)
        {
            case 2:
                readTheSecondDigit = "twenty";
                break;
            case 3:
                readTheSecondDigit = "thirty";
                break;
            case 4:
                readTheSecondDigit = "fourty";
                break;
            case 5:
                readTheSecondDigit = "fifty";
                break;
            case 6:
                readTheSecondDigit = "sixty";
                break;
            case 7:
                readTheSecondDigit = "seventy";
                break;
            case 8:
                readTheSecondDigit = "eigthy";
                break;
            case 9:
                readTheSecondDigit = "ninеty";
                break;
            default:
                Console.WriteLine("There is an error");
                break;
        }
        switch (lastDigit)
        {
            case 1:
                readTheLastDigit = "one";
                break;
            case 2:
                readTheLastDigit = "two";
                break;
            case 3:
                readTheLastDigit = "three";
                break;
            case 4:
                readTheLastDigit = "four";
                break;
            case 5:
                readTheLastDigit = "five";
                break;
            case 6:
                readTheLastDigit = "six";
                break;
            case 7:
                readTheLastDigit = "seven";
                break;
            case 8:
                readTheLastDigit = "eight";
                break;
            case 9:
                readTheLastDigit = "nine";
                break;
            default:
                Console.WriteLine("There is an error");
                break;
        }
    }

    static void unusualCases()
    {
        int endOfTheNumber;
        endOfTheNumber = numberToRead % 100;
        switch (endOfTheNumber)
        {
            case 0:
                readUnusualNumberEndings = "zero";
                break;
            case 1:
                readUnusualNumberEndings = "one";
                break;
            case 2:
                readUnusualNumberEndings = "two";
                break;
            case 3:
                readUnusualNumberEndings = "three";
                break;
            case 4:
                readUnusualNumberEndings = "four";
                break;
            case 5:
                readUnusualNumberEndings = "five";
                break;
            case 6:
                readUnusualNumberEndings = "six";
                break;
            case 7:
                readUnusualNumberEndings = "seven";
                break;
            case 8:
                readUnusualNumberEndings = "eight";
                break;
            case 9:
                readUnusualNumberEndings = "nine";
                break;
            case 10:
                readUnusualNumberEndings = "ten";
                break;
            case 11:
                readUnusualNumberEndings = "eleven";
                break;
            case 12:
                readUnusualNumberEndings = "twelve";
                break;
            case 13:
                readUnusualNumberEndings = "thirteen";
                break;
            case 14:
                readUnusualNumberEndings = "fourteen";
                break;
            case 15:
                readUnusualNumberEndings = "fifteen";
                break;
            case 16:
                readUnusualNumberEndings = "sixteen";
                break;
            case 17:
                readUnusualNumberEndings = "seventeen";
                break;
            case 18:
                readUnusualNumberEndings = "eighteen";
                break;
            case 19:
                readUnusualNumberEndings = "nineteen";
                break;
            case 20:
                readUnusualNumberEndings = "twenty";
                break;
            case 30:
                readUnusualNumberEndings = "thirty";
                break;
            case 40:
                readUnusualNumberEndings = "fourty";
                break;
            case 50:
                readUnusualNumberEndings = "fifty";
                break;
            case 60:
                readUnusualNumberEndings = "sixty";
                break;
            case 70:
                readUnusualNumberEndings = "seventy";
                break;
            case 80:
                readUnusualNumberEndings = "eighty";
                break;
            case 90:
                readUnusualNumberEndings = "ninety";
                break;
        }
    }

    static void Main()
    {
        ReadTheNumber();
        if (numberToRead > 99) // check if the number has more than 2 digits
        {
            ReadTheHundreds();
            if (((numberToRead % 100) > 19) && ((numberToRead % 10) != 0))
            //check if the number don't end with numbers in the range of [0..19] or end with 0
            {
                ReadSecondAndThirdDigits();
                Console.WriteLine("Your number {0} is {1} {2} {3}", numberToRead, readTheHundreds, readTheSecondDigit, readTheLastDigit);
            }
            else
            {
                if ((numberToRead % 100) != 0)
                {
                    unusualCases();
                    Console.WriteLine("Your number {0} is {1} and {2}", numberToRead, readTheHundreds, readUnusualNumberEndings);
                }
                else
                {
                    Console.WriteLine("Your number {0} is {1}", numberToRead, readTheHundreds);
                }
            }
        }
        else if (((numberToRead % 100) > 19) && ((numberToRead % 10) != 0))
        {
            ReadSecondAndThirdDigits();
            Console.WriteLine("Your number {0} is {1} {2}", numberToRead, readTheSecondDigit, readTheLastDigit);
        }
        else if (((numberToRead % 100) < 20) || ((numberToRead % 10) == 0))
        {
            unusualCases();
            Console.WriteLine("Your number {0} is {1}", numberToRead, readUnusualNumberEndings);

        }
    }
}
