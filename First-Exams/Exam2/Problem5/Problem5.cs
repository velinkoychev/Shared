using System;
using System.Threading;
using System.Globalization;

class Problem5
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int[,] squareGrid = new int[8, 8];
        for (int i = 0; i < 8; i++)   // input numbers
        {
            int tempNumber = int.Parse(Console.ReadLine());
            if (tempNumber > 127)
            {
                squareGrid[i, 7] = 1;
                tempNumber = tempNumber - 128;
            }
            if (tempNumber > 63)
            {
                squareGrid[i, 6] = 1;
                tempNumber = tempNumber - 64;
            }
            if (tempNumber > 31)
            {
                squareGrid[i, 5] = 1;
                tempNumber = tempNumber - 32;
            }
            if (tempNumber > 15)
            {
                squareGrid[i, 4] = 1;
                tempNumber = tempNumber - 16;
            }
            if (tempNumber > 7)
            {
                squareGrid[i, 3] = 1;
                tempNumber = tempNumber - 8;
            }
            if (tempNumber > 3)
            {
                squareGrid[i, 2] = 1;
                tempNumber = tempNumber - 4;
            }
            if (tempNumber > 1)
            {
                squareGrid[i, 1] = 1;
                tempNumber = tempNumber - 2;
            }
            if (tempNumber > 0)
            {
                squareGrid[i, 0] = 1;
                tempNumber = tempNumber - 1;
            }
        }
        int numberOfLines = 0;
        int sizeOfTheBiggestLine = 0;
        int sizeOfTheLine = 0;
        for (int i = 0; i < 8; i++)
        {
            sizeOfTheLine = 0;
            for (int j = 0; j < 8; j++)
            {
                if (squareGrid[i, j] == 1)
                {
                    sizeOfTheLine++;
                }
                if ((squareGrid[i, j] == 0)||(j==7))
                {
                    if (sizeOfTheLine==sizeOfTheBiggestLine)
                    {
                        numberOfLines++;
                    }
                    if (sizeOfTheLine > sizeOfTheBiggestLine)
                    {
                        sizeOfTheBiggestLine = sizeOfTheLine;
                        numberOfLines = 1;
                    }
                    sizeOfTheLine = 0;
                }
            }
        }
        for (int i = 0; i < 8; i++)
        {
            sizeOfTheLine = 0;
            for (int j = 0; j < 8; j++)
            {
                if (squareGrid[j, i] == 1)
                {
                    sizeOfTheLine++;
                }
                if ((squareGrid[j, i] == 0) || (j == 7))
                {
                    if (sizeOfTheLine == sizeOfTheBiggestLine)
                    {
                        numberOfLines++;
                    }
                    if (sizeOfTheLine > sizeOfTheBiggestLine)
                    {
                        sizeOfTheBiggestLine = sizeOfTheLine;
                        numberOfLines = 1;
                    }
                    sizeOfTheLine = 0;
                    
                }
            }
        }
        Console.WriteLine(sizeOfTheBiggestLine);
        if (sizeOfTheBiggestLine == 1)
        {
            Console.WriteLine(numberOfLines/2);
        }
        else
        Console.WriteLine(numberOfLines);
        
    }
}
