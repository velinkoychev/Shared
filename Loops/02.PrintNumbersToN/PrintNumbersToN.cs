using System;
class PrintNumbersToN
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
            if ((i % 21)!=0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
