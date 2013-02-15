using System;

class Program
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberN ; i++)
        {
            for (int j = 0; j < numberN; j++)
            {
                if (j == i)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }

            }
            Console.WriteLine();
        }
        for (int i = numberN - 2; i > -1; i--)
        {
            for (int j = 0; j < numberN ; j++)
            {
                if (j == i)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }

            }
            Console.WriteLine();
        }
    } 
}

