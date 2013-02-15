using System;
using System.Numerics;
class Problem4
{
    static void Main()
    {
        int digitB = int.Parse(Console.ReadLine());
        uint numberN = uint.Parse(Console.ReadLine());
        for (int i = 0; i < numberN ; i++)
        {
            uint p = uint.Parse(Console.ReadLine());
            double numberOf1s = 0;
            double numberOf0s = 0;
            for (int j = 31; j >=0; j--)
            {

                int mask = 1 << j;
                if (((mask & p) != 0))
                {
                    numberOf1s ++;
                    if (digitB == 0)
                    {
                        for (int z = j; z >=0; z--)
                        {
                            mask = 1 << z;
                            if (((mask & p) == 0))
                            {
                                numberOf0s++;
                            }
                        }
                        break;
                    }
                }
            }
            if (digitB == 1)
            {
                Console.WriteLine(numberOf1s);
            }
            else if (digitB == 0)
            {
                Console.WriteLine(numberOf0s);
            }
        }

    }
}

