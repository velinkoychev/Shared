using System;

class Problem5
{
    static void Main()
    {
        int[,] squareGrid = new int[8, 8];
        bool noLine = true;
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


        int fullPillarNumber = 0;     // find the number of pillar that is the only one with number (if there is only one)
        int numberOfFullPillars = 0;  // find the number of full pillars
        for (int i = 0; i < 8; i++)   // check if there is a full pillar
        {
            bool fullRow = false;
            for (int j = 0; j < 8; j++)
            {
                if (squareGrid[j, i] == 1)
                {
                    fullRow = true;
                }
            }
            if (fullRow)
            {
                numberOfFullPillars++;
                fullPillarNumber = i;
            }
        }

        if (numberOfFullPillars == 1)       // if there is only one full piller the answer would be crossing this pillar
        {
            Console.WriteLine(fullPillarNumber);
            Console.WriteLine(0);
        }
        else if (numberOfFullPillars == 0) // if there is no full pillars
        {
            Console.WriteLine(7);
            Console.WriteLine(0);
        }
        else   // every other case
        {
            for (int i = 6; i > 0; i--)
            {
                int fullCells1 = 0;
                int fullCells2 = 0;
                for (int j = 0; j < i; j++)  // checking the left side
                {
                    for (int z = 0; z < 8; z++)
                    {
                        if (squareGrid[z, j] == 1)
                        {
                            fullCells1++;
                        }
                    }
                }
                for (int j = i + 1; j < 8; j++) // checking the right side
                {
                    for (int z = 0; z < 8; z++)
                    {
                        if (squareGrid[z, j] == 1)
                        {
                            fullCells2++;
                        }
                    }
                }
                if ((fullCells1 == fullCells2) && (fullCells2 != 0))   // if there the number of full cells in the left and in the right side is equal
                {
                    Console.WriteLine(i);
                    Console.WriteLine(fullCells2);
                    noLine = false;
                    break;
                }
            }

            if (noLine)  // if there is no answer
            {
                Console.WriteLine("No");
            }
        }
    }
}
