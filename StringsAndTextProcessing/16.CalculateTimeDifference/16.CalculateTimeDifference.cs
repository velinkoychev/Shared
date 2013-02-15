//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 

using System;

class CalculateTimeDifference
{
    static void Main()
    {
        Console.Write("Please, enter the first date = ");
        string[] startDate = Console.ReadLine().Split('.');
        Console.Write("Please, enter the second date = ");
        string[] endDate = Console.ReadLine().Split('.');
        try
        {
            DateTime startingDate = new DateTime(int.Parse(startDate[2]), int.Parse(startDate[1]), int.Parse(startDate[0]));
            DateTime endingDate = new DateTime(int.Parse(endDate[2]), int.Parse(endDate[1]), int.Parse(endDate[0]));
            Console.WriteLine("There are {0} days between these two dates",(endingDate - startingDate).TotalDays);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Sorry, there was a problem with your input. Please try again!");
            Console.WriteLine(ex.Message);
        }
    }
}
