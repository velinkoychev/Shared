using System;

class Problem4
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int[] numberSeries = new int[numberN];
        for (int i = 0; i < numberN; i++)
        {
            numberSeries[i] = int.Parse(Console.ReadLine());
            int invertedNumber = numberSeries[i];
            int reversedNumber = numberSeries[i];
            int first1Digit = 0;
            for (int j = 31; j >= 0; j--)    // finding the first digit in the binary number
            {
                int mask = 1 << j;
                int nAndMask = invertedNumber & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    first1Digit = j;
                    break;
                }
            }
            for (int j = first1Digit; j >= 0; j--)
            {
                int mask = 1 << j;
                int nAndMask = invertedNumber & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    mask = ~(1 << j);
                    invertedNumber = invertedNumber & mask;
                }
                if (bit == 0)
                {
                    mask = 1 << j;
                    invertedNumber = invertedNumber | mask;
                }

            }
            int middleNumber = first1Digit / 2;
            for (int z = first1Digit, v = 0; z > middleNumber; z--, v++)
            {
                int mask1 = 1 << z;
                int mask2 = 1 << v;
                mask1 = (((mask1 & reversedNumber) >> z) << v);
                mask2 = (((mask2 & reversedNumber) >> v) << z);
                reversedNumber = (reversedNumber & (~(1 << v)));
                reversedNumber = reversedNumber | mask1;
                reversedNumber = (reversedNumber & (~(1 << z)));
                reversedNumber = reversedNumber | mask2;
            }
            int pNewNumber = (numberSeries[i] ^ invertedNumber) & reversedNumber;
            numberSeries[i] = pNewNumber;
        }
        for (int i = 0; i < numberN; i++)
        {
            Console.WriteLine(numberSeries[i]);
        }
    }
}
