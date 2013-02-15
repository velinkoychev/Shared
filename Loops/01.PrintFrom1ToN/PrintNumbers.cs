using System;

class PrintNumbers
{
    static void Main()
    {
        int n;
        bool correctInput;
        do
        {
        Console.Write("Please, write number N= ");
        correctInput = int.TryParse(Console.ReadLine(), out n);
        }
        while (!correctInput);
        for (int i = 1; i < n+1; i++)
        {
            Console.WriteLine(i);
        }
    }
}

