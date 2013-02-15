using System;

class FindBit3
{
    static void Main()
    {
        int testInteger;
        bool checkBit3;
        Console.WriteLine("Write the value");
        int.TryParse(Console.ReadLine(), out testInteger);
        checkBit3 = ((testInteger & 8) == 0);
        Console.WriteLine(checkBit3 ? "the bit 3 is 0" : "the bit 3 is 1" );
    }
}

