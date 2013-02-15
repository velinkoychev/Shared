using System;
class Problem3
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberN/2 +1 ; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write('.');
            }
            for (int j = i; j < numberN - i; j++)
            {
                Console.Write('*');
            }
            for (int j = 0; j < i; j++)
            {
                Console.Write('.');
            }
            Console.WriteLine();
        }
        for (int i = numberN / 2-1; i >= 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write('.');
            }
            for (int j = i; j < numberN - i; j++)
            {
                Console.Write('*');
            }
            for (int j = 0; j < i; j++)
            {
                Console.Write('.');
            }
            Console.WriteLine();
        }
    }
}

