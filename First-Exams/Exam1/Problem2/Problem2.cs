using System;
using System.Numerics;

class Problem2
{
    static void Main()
    {
        BigInteger tn3 = BigInteger.Parse(Console.ReadLine());
        BigInteger tn2 = BigInteger.Parse(Console.ReadLine());
        BigInteger tn1 = BigInteger.Parse(Console.ReadLine());
        int tnNumber = int.Parse(Console.ReadLine());
        BigInteger tnNew = 0;

        if (tnNumber == 1)
        {
            Console.WriteLine(tn3);
        }
        else if (tnNumber == 2)
        {
            Console.WriteLine(tn2);
        }
        else if (tnNumber == 3)
        {
            Console.WriteLine(tn1);
        }
        else
        {
            for (int i = 3; i < tnNumber; i++)
            {
                tnNew = tn1 + tn2 + tn3;
                tn3 = tn2;
                tn2 = tn1;
                tn1 = tnNew;
            }
            Console.WriteLine(tnNew);
        }
    }
}

