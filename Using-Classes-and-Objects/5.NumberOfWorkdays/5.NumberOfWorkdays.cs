// Write a method that calculates the number of workdays between today and given date, passed as parameter.
// Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.


using System;
class NumberOfWorkdays
{
    static DateTime[] holidays = {   new DateTime(2012, 12, 31), new DateTime(2013, 01, 01),
                                     new DateTime(2013, 03, 03), new DateTime(2013, 05, 06), new DateTime(2013, 05, 24),
                                     new DateTime(2013, 09, 06), new DateTime(2013, 09, 22), new DateTime(2013, 12, 24), new DateTime(2013, 12, 25)};
   
    static int CountDays(DateTime startDay, DateTime finalDay)
    {
        int count = 0;
        for (DateTime day = startDay; day <= finalDay; day = day.AddDays(1))
        {
            bool workday = true;
            if ((day.DayOfWeek==DayOfWeek.Saturday)||(day.DayOfWeek==DayOfWeek.Sunday))
            {
                workday = false;
            }
            foreach (DateTime holiday in holidays)
            {
                if ((holiday.Day == day.Day)&&(holiday.Month==day.Month))
                {
                    workday = false;
                }
            }
            if (workday)
            {
                count++;
            }
        }
        return count;
    }
    static void Main()
    {
        DateTime startDay = DateTime.Today;
        Console.Write("Enter the date <DD-MM-YYYY>:");
        DateTime finalDay= DateTime.Parse(Console.ReadLine());
        if (startDay < finalDay)
        {
            Console.WriteLine(CountDays(startDay, finalDay));
        }
        else
        {
            Console.WriteLine(CountDays(finalDay,startDay));
        }
    }
}
