using System;
using System.Threading;
using System.Globalization;

class Problem4
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int x = int.Parse(Console.ReadLine());
        int halfLenght = (x - 1) / 2;
        for (int i = 0; i < halfLenght; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write('.');
            }
            Console.Write("\\");
            for (int j = 0; j < halfLenght - 1 - i; j++)
            {
                Console.Write('.');
            }
            Console.Write("|");
            for (int j = 0; j < halfLenght - 1 - i; j++)
            {
                Console.Write('.');
            }
            Console.Write("/");
            for (int j = 0; j < i; j++)
            {
                Console.Write('.');
            }
            Console.WriteLine();
        }
        for (int i = 0; i < halfLenght; i++)
        {
            Console.Write('-');
        }
        Console.Write("*");
        for (int i = 0; i < halfLenght; i++)
        {
            Console.Write('-');
        }
        Console.WriteLine();
        for (int i = 0; i < halfLenght; i++)
        {
            for (int j = 0; j < halfLenght - 1 - i; j++)
            {
                Console.Write('.');
            }
            Console.Write("/");
            for (int j = 0; j < i; j++)
            {
                Console.Write('.');
            }
            Console.Write("|");
            for (int j = 0; j < i; j++)
            {
                Console.Write('.');
            }
                        Console.Write("\\");
            for (int j = 0; j < halfLenght - 1 - i; j++)
            {
                Console.Write('.');
            }
            Console.WriteLine();
        }
    }

}

