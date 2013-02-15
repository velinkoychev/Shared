// Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. Display them in the standard date format for Canada.

using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Globalization;

class ExtractDates
{
    static void Main()
    {
        string textWithDates = @"//fklwe12.03.2017. lmelkf01.12.2001 12.13.2003";
        SearchForDates(textWithDates);
        Console.WriteLine("Please, enter the text with dates: ");
        textWithDates = Console.ReadLine();
        SearchForDates(textWithDates);
    }

    private static void SearchForDates(string textWithDates)
    {
        string pattern = @"\d{1,2}.\d{1,2}.\d{4}";
        Match match = Regex.Match(textWithDates, pattern);
        List<DateTime> foundDates = new List<DateTime>();
        while (match.Success)
        {
            DateTime newDate = new DateTime();
            bool correctDate = false;
            correctDate = DateTime.TryParseExact(match.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out newDate);
            if (correctDate)
            {
            foundDates.Add(newDate);
            }
            match = match.NextMatch();
        }
        foreach (DateTime date in foundDates)
        {
            Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
        }
    }
}
