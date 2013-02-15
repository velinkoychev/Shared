using System;

class BooleanExpression
{
    static void Main()
    {
        int numberV;
        int mask;
        byte positionP;
        bool isBitPEqual1;
        Console.WriteLine("Type number v...");
        numberV = int.Parse(Console.ReadLine());
        Console.WriteLine("Type position p...");
        positionP = byte.Parse(Console.ReadLine());
        mask = 1 << positionP;
        isBitPEqual1 = ((mask & numberV) != 0);
        Console.WriteLine( "Bit number " + positionP +" equals 1: " + isBitPEqual1);
    }
}

