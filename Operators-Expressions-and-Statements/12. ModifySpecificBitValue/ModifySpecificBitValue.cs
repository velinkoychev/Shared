using System;

class ModifySpecificBitValue
{
    static void Main()
    {
        int numberN, mask;
        byte positionP, valueV;
        Console.WriteLine("Type integer number n...");
        numberN = int.Parse(Console.ReadLine());
        Console.WriteLine("Type bit position p...");
        positionP = byte.Parse(Console.ReadLine());
        Console.WriteLine("Write value V (0 or 1)...");
        valueV = byte.Parse(Console.ReadLine());
        mask = 1 << positionP;
        numberN = (numberN & (~mask));
        numberN = numberN | (valueV<<positionP) ;
        Console.WriteLine("number n = " + numberN);

    }
}

