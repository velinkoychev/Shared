using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        bool correctInput;
        int n;
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
        BigInteger lastFibonacciNumber = 0;
        BigInteger fibonacciNumber = 1;
        BigInteger nextFibonacciNumber;
        Console.Write("The first {0} Fibonacci numbers are: 0,", n);
        for (int counter = 2; counter <= n; counter++)
        {
            Console.WriteLine(" {0};", fibonacciNumber);
            nextFibonacciNumber = lastFibonacciNumber + fibonacciNumber;
            lastFibonacciNumber = fibonacciNumber;
            fibonacciNumber = nextFibonacciNumber;
        }
    }
}

