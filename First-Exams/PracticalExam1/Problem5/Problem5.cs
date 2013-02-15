using System;

class Problem5
{
    static void Main()
    {
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
        for (int i = 7; i >= 0; i--) // recalculate numbers
        {
            for (int z = 0; z < 8; z++)
            {
                if (squareGrid[z, i] == 1)
                {
                    for (int j = 7; j > z; j--)
                    {
                        if (squareGrid[j, i] == 0)
                        {
                            squareGrid[j, i] = 1;
                            squareGrid[z, i] = 0;
                            break;
                        }
                    }
                }
            }
        }
        for (int i = 0; i < 8; i++) // print numbers
        {
            int printNumber = 0;
            for (int z = 7; z >= 0; z--)
            {
                if (squareGrid[i, z] == 1)
                {
                    printNumber = printNumber + (int)Math.Pow(2, z);
                }
            }
            Console.WriteLine(printNumber);
        }
    }
}

