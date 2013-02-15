using System;
using System.Numerics;
using System.Threading;
using System.Globalization;
 
class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int numberK = int.Parse(Console.ReadLine());
        int numberN = int.Parse(Console.ReadLine());
        int lastDigit = 2;
        int counter = 0;
        int numberOfEqualDigits = 0;
        for (int i = 0; i < numberN; i++)
        {
            int positiveInteger = int.Parse(Console.ReadLine());
            int firstOne = 0;
            for (int j = 31; j >= 0; j--)
            {
                int mask = 1 << j;
                int nAndMask = positiveInteger & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    firstOne = j;
                    break;
                }
            }
            for (int j = firstOne; j >= 0; j--)
            {
                int mask = 1 << j;
                int nAndMask = positiveInteger & mask;
                int bit = nAndMask >> j;
                if (bit == lastDigit)
                {
                    numberOfEqualDigits++;
                }
                if (bit != lastDigit)
                {
                    lastDigit = bit;
                    if (numberOfEqualDigits == numberK)
                    {
                        counter++;
                    }
                    numberOfEqualDigits = 1;
                }
            }
            
        }
        if (numberOfEqualDigits == numberK)
        {
            counter++;
        }
        Console.WriteLine(counter);
    }
}
