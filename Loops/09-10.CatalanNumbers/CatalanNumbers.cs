using System;

class CatalanNumbers
{
    static void Main()
    {
        int n;
        double  nthCatalanNumber;
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
        double nFactorial = 1;
        for (int i = 2; i < n + 1; i++)
        {
            nFactorial *= i;
        }
        double secondFactorial=nFactorial;
        for (int i = n+1; i < 2*n+1; i++)
        {
            secondFactorial *=i;    
        }
        nthCatalanNumber = secondFactorial/((nFactorial*(n+1))*nFactorial);
        Console.WriteLine("{0}th Catalan number = {1}",n, nthCatalanNumber);
    }
}

