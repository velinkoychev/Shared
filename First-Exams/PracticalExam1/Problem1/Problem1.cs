using System;
using System.Threading;
using System.Globalization;


class Problem1
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        decimal n = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());
        int angle = (int)m % (int)180;
        decimal result;
        result = (n*n+ (1/(m*p)) + 1337)/ (n - Convert.ToDecimal(128.523123123) * p) + Convert.ToDecimal( Math.Sin(angle ));
        result = Math.Round(result, 6);
        Console.WriteLine(result);
    }
}

