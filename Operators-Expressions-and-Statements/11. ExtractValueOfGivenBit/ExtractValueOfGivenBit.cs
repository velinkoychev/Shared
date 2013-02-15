using System;

class ExtractValueOfGivenBit
{
    static void Main(string[] args)
    {
        int integerI, mask;
        byte positionB;
        Console.WriteLine("Type integer i...");
        integerI = int.Parse(Console.ReadLine());
        Console.WriteLine("Type bit number b...");
        positionB = byte.Parse(Console.ReadLine());
        mask = 1 << positionB;
        if (((mask & integerI) != 0))
        {
            Console.WriteLine("Value = 1");
        }
        else
        {
            Console.WriteLine("Value = 0");
        }

    }
}

