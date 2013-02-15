using System;
class Problem3
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberN; i++)
        {
            Console.Write(".");
        }
        for (int i = 0; i < numberN; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        for (int i = numberN - 1; i > 0; i--)
        {
            int j = i;
            while (j != 0)
            {
                Console.Write(".");
                j--;
            }
            Console.Write("*");
            int z = 2*numberN -2 - i;
            while (z != 0)
            {
                Console.Write(".");
                z--;
            }
            Console.WriteLine("*");
        }
        for (int i = 0; i < 2*numberN ; i++)
        {
            Console.Write("*");
        }
    }
}

