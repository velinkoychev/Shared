using System;

class CalculateSum
{
    static void Main()
    {
        int n, x;
        double sum = 1;
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
        do
        {
            Console.Write("Please, write number X= ");
            correctInput = int.TryParse(Console.ReadLine(), out x);
            if (x < 1)
            {
                correctInput = false;
            }
        }
        while (!correctInput);
        for (int i = 1; i < n + 1; i++)
        {
            double nFactorial = 1;
            for (int j = 2; j < i + 1; j++)
            {
                nFactorial *= j;
            }
            sum = sum + nFactorial / Math.Pow(x,i);
        }
        Console.WriteLine("S=" + sum);
    }
}

