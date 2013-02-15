//Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
//and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.


using System;
using System.Globalization;
class ReadDateAndTime
{
    private static void PrintFutureTime(string enteredDate)
    {
        DateTime date = DateTime.ParseExact(enteredDate, "d.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        date = date.AddHours(6);
        date = date.AddMinutes(30);
        Console.WriteLine("After 6 hrs 30 mins it will be: {0}, {1}", date, date.ToString("dddd", new CultureInfo("bg-BG")));
    }

    static void Main()
    {

        string enteredDate = "3.02.2013 20:00:00";
        PrintFutureTime(enteredDate);
        Console.Write("Please, enter the date: ");
        enteredDate = Console.ReadLine();
        try
        {
            PrintFutureTime(enteredDate);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Sorry, there was a problem with your input. Please try again!");
            Console.WriteLine(ex.Message);
        }
    }

    
}

