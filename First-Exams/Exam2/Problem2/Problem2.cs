using System;
using System.Threading;
using System.Globalization;

class Problem2
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        ulong sumOfTheDigits = 0;

        // read all the digits
        ulong readCharNumber = (ulong)'0';
        while ((readCharNumber != 13) && (readCharNumber != 10))
        {
            if ((readCharNumber != 46)&&(readCharNumber != 45))  // we don't need to read only '.' and '-'
            {
                sumOfTheDigits = sumOfTheDigits + readCharNumber - (ulong)'0';
            }
            readCharNumber = (ulong)Console.Read();
        }
        // check if the obtained result is bigger than 9 
        while (sumOfTheDigits > 9)
        {
            ulong newSumOfTheDigits = 0;
            while (sumOfTheDigits != 0)
            {
                newSumOfTheDigits = newSumOfTheDigits + (sumOfTheDigits % 10);
                sumOfTheDigits = (sumOfTheDigits - (sumOfTheDigits % 10)) / 10;
            }
            sumOfTheDigits = newSumOfTheDigits;
        }
        Console.WriteLine(sumOfTheDigits);
    }
}

