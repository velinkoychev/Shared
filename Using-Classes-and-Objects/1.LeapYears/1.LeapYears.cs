//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;
class LeapYears
{
    static void Main()
    {
        int year=0;
        bool correctInput = false;
        while (!correctInput)
        {
            Console.Write("Please, enter the year =");
            correctInput = int.TryParse(Console.ReadLine(), out year);
        }
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("Yes, it is a leap year");
        }
        else
        {
            Console.WriteLine("No, it is not a leap year" );
        }
    }
}

