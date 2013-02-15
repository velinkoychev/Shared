using System;
class ExchangeSeriesOfBits
{
    static void Main()
    {
       
        uint unsighnedInteger,unsighnedIntegerCopy, mask1, mask2;
        byte bitP, bitQ, differenceK, bitPFixed;
        Console.WriteLine("Type unsigned integer...");
        unsighnedInteger = uint.Parse(Console.ReadLine());
        unsighnedIntegerCopy = unsighnedInteger;
        Console.WriteLine("Type p=...");
        bitP = byte.Parse(Console.ReadLine());
        bitPFixed = bitP;
        Console.WriteLine("Type q=...");
        bitQ = byte.Parse(Console.ReadLine());
        Console.WriteLine("Type k=...");
        differenceK = byte.Parse(Console.ReadLine());
        Console.WriteLine("Your number in binary numeral system = " + Convert.ToString(unsighnedInteger,2).PadLeft(32,'0'));
        while (bitP <= (bitPFixed +differenceK - 1) )
        {
            mask1 = (uint)1 << bitP;
            mask2 = (uint)1 << bitQ;
            mask1 = (((mask1 & unsighnedInteger) >> bitP) << bitQ);
            mask2 = (((mask2 & unsighnedInteger) >> bitQ) << bitP);
            unsighnedInteger = (unsighnedInteger & (~((uint)1 << bitQ)));
            unsighnedInteger = unsighnedInteger | mask1;
            unsighnedInteger = (unsighnedInteger & (~((uint)1 << bitP)));
            unsighnedInteger = unsighnedInteger | mask2;
            bitP++;
            bitQ++;
        }
        Console.WriteLine("The new number = " + unsighnedInteger);
        Console.WriteLine("The new number in binary numeral system = " + Convert.ToString(unsighnedInteger, 2).PadLeft(32, '0'));
    }
}

