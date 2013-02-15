using System;

class Problem5
{
    static void Main()
    {
        long numberS = long.Parse(Console.ReadLine());
        long numberSCheck =0;
        int numberN = int.Parse(Console.ReadLine());
        int counter=0;
        long[] numbersArray = new long[numberN];
        for (int i = 0; i < numberN; i++)
        {
            numbersArray[i] = long.Parse(Console.ReadLine());
        }
        int maxi = (int)Math.Pow(2, numberN) - 1;
        for (int z = 1; z <= maxi; z++)
        {
            for (int i = 0; i <= numberN; i++)
            {
                int mask;
                mask = 1 << i;
                if (((mask & z) != 0))
                {
                    numberSCheck = numberSCheck + numbersArray[i];
                }
            }
            if (numberSCheck == numberS)
            {
                counter++;
            }
            numberSCheck = 0;
        }
        Console.WriteLine(counter);
        
    }
}

