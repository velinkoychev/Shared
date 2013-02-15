using System;
class PrintFirst100FibonaciiNumbers
{
    static void Main()
    {
        decimal lastFibonacciNumber =0;
        decimal fibonacciNumber = 1;
        decimal  nextFibonacciNumber;
        Console.Write("The first 100 Fibonacci numbers are: 0,");
        for (int counter = 2; counter <= 100; counter++)
        {
            Console.Write(" {0},",fibonacciNumber);
            nextFibonacciNumber = lastFibonacciNumber + fibonacciNumber;
            lastFibonacciNumber = fibonacciNumber;
            fibonacciNumber = nextFibonacciNumber;
        }
    }
}

