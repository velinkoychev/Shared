using System;
class ExchangeBits
{
    static void Main()
    {
        uint unsighnedInteger, mask1, mask2;
        byte bitP = 3;
        byte bitQ = 24;
        Console.WriteLine("Type unsigned integer...");
        unsighnedInteger = uint.Parse(Console.ReadLine());
        while (bitP <= 5)
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
    }
}

