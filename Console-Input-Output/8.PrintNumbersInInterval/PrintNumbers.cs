using System;

class PrintNumbers
{
    static void Main()
    {
        int numberN;
        Console.Write("Please, write number n = ");
        numberN = int.Parse(Console.ReadLine());
        for (int counter = 0; counter <= numberN; counter++)
        {
            Console.WriteLine(counter);
        }
    }
}

