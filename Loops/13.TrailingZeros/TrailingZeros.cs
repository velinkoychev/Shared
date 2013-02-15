using System;
using System.Numerics;
class TrailingZeros
{
    static void Main()
    {
        int n;
        bool correctInput;
        do
        {
            Console.Write("Please, write number N= ");
            correctInput = int.TryParse(Console.ReadLine(), out n);
            if (n < 1)
            {
                correctInput = false;
            }
        }
        while (!correctInput);
        BigInteger  nFactorial = 1;
        for (int i = 2; i < n + 1; i++)
        {
            nFactorial *= i;
        }
        Console.WriteLine("N! = " + nFactorial);
        Console.WriteLine("The number of trailing zero = " + n/5);
        
    }
}

