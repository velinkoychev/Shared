using System;

class Sequence
{
    static void Main()
    {
        int n;
        int number;
        int minimalNumber=0;
        int maximalNumber=0;
        bool correctInput;
        do
        {
            Console.Write("Please, write number N= ");
            correctInput = int.TryParse(Console.ReadLine(), out n);
        }
        while (!correctInput);
        for (int i = 1; i < n; i++)
        {
            do
            {
                Console.Write("Please, write number {0} = ", i);
                correctInput = int.TryParse(Console.ReadLine(), out number);
            }
            while (!correctInput);
            if (i == 1)
            {
                maximalNumber = number;
                minimalNumber = number;
                continue;
            }
            if (number > maximalNumber)
            {
                maximalNumber = number;
            }
            if (number < minimalNumber)
            {
                minimalNumber = number;
            }
        }
        Console.WriteLine("The maximum number = {0} and the minimum number = {1}", maximalNumber, minimalNumber);
    }
}

