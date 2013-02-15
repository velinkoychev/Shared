using System;
class CalculateDivision
{
    static void Main()
    {
        int n, k;
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
            Console.Write("Please, write number K= ");
            correctInput = int.TryParse(Console.ReadLine(), out k);
            if (k < n)
            {
                correctInput = false;
            }
        }
        while (!correctInput);
        double nFactorial = 1;
        for (int i = 2; i < n + 1; i++)
        {
            nFactorial *= i;
        }

        double kFactorial = 1;
        for (int i = 2; i < k + 1; i++)
        {
            kFactorial *= i;
        }
        double knFactorial = 1;
        for (int i = 2; i < k - n + 1; i++)
        {
            kFactorial *= i;
        }
        double result;
        result = (nFactorial * kFactorial)/knFactorial;
        Console.WriteLine("N!*K! / (K-N)! = " + result);
    }
}

