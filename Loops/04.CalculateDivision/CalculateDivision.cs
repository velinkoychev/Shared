using System;
class CalculateDivision
{
    static void Main()
    {
        double n,k;
        bool correctInput;
        do
        {
            Console.Write("Please, write number K= ");
            correctInput = double.TryParse(Console.ReadLine(), out k);
            if (k < 1)
            {
                correctInput = false;
            }
        }
        while (!correctInput);
        do
        {
            Console.Write("Please, write number N= ");
            correctInput = double.TryParse(Console.ReadLine(), out n);
            if (n < k)
            {
                correctInput = false;
            }
        }
        while (!correctInput);
        double nFactorial = 1;
        for (int i = 2; i < n+1; i++)
        {
            nFactorial *= i;
        }

        double kFactorial = 1;
        for (int i = 2; i < k + 1; i++)
        {
            kFactorial *= i;
        }
        double result;
        result = nFactorial / kFactorial;
        Console.WriteLine("N!/K! = " + result );
    }
}

