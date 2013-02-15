using System;
using System.Threading;
using System.Globalization;

class Problem5
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int[,] m = new int[8, 16];
        for (int row = 0; row < 8; row++)
        {
            int bits = int.Parse(Console.ReadLine());
            for (int col = 0; col < 16; col++)
            {
                if ((bits & (1 << col)) != 0)
                {
                    m[row, col] = 1;
                }
            }
        }
        int flight = 0;
        int hitCount = 0;
        int score = 0;
        for (int col = 8; col < 16; col++)
        {
            flight = 0;
            hitCount = 0;
            for (int row = 0; row < 8; row++)
            {
                if (m[row, col] == 1)
                {
                    m[row, col] = 0;
                    int newRow = row;
                    int newCol = col;
                    bool hit = false;
                    while (newRow > 0)
                    {
                        flight++;
                        newRow--;
                        newCol--;
                        if (m[newRow, newCol] == 1)
                        {
                            hitCount++;
                            m[newRow, newCol] = 0;
                            if (newRow > 0)
                            {
                                if (m[newRow - 1, newCol] == 1)
                                {
                                    hitCount++;
                                    m[newRow - 1, newCol] = 0;
                                }
                                if (m[newRow - 1, newCol + 1] == 1)
                                {
                                    hitCount++;
                                    m[newRow - 1, newCol + 1] = 0;
                                }
                                if (m[newRow - 1, newCol - 1] == 1)
                                {
                                    hitCount++;
                                    m[newRow - 1, newCol - 1] = 0;
                                }
                            }
                            if (m[newRow, newCol] == 1)
                            {
                                hitCount++;
                                m[newRow, newCol] = 0;
                            }
                            if (m[newRow, newCol + 1] == 1)
                            {
                                hitCount++;
                                m[newRow, newCol + 1] = 0;
                            }
                            if (m[newRow, newCol - 1] == 1)
                            {
                                hitCount++;
                                m[newRow, newCol - 1] = 0;
                            }
                            if (m[newRow + 1, newCol] == 1)
                            {
                                hitCount++;
                                m[newRow + 1, newCol] = 0;
                            }
                            if (m[newRow + 1, newCol + 1] == 1)
                            {
                                hitCount++;
                                m[newRow + 1, newCol + 1] = 0;
                            }
                            if (m[newRow + 1, newCol - 1] == 1)
                            {
                                hitCount++;
                                m[newRow + 1, newCol - 1] = 0;
                            }
                            hit = true;
                            score = score + flight * hitCount;
                            break;
                        }
                    }
                    while ((newRow < 7) && (newCol > 0) && !hit)
                    {
                        flight++;
                        newRow++;
                        newCol--;
                        if (m[newRow, newCol] == 1)
                        {
                            hitCount++;
                            m[newRow, newCol] = 0;
                            if ((newCol > 0)&&(newRow < 7))
                            {
                                if (m[newRow + 1, newCol] == 1)
                                {
                                    hitCount++;
                                    m[newRow + 1, newCol] = 0;
                                }
                                if (m[newRow + 1, newCol + 1] == 1)
                                {
                                    hitCount++;
                                    m[newRow + 1, newCol + 1] = 0;
                                }
                                if (m[newRow + 1, newCol - 1] == 1)
                                {
                                    hitCount++;
                                    m[newRow + 1, newCol - 1] = 0;
                                }
                                if (m[newRow, newCol] == 1)
                                {
                                    hitCount++;
                                    m[newRow, newCol] = 0;
                                }
                                if (m[newRow, newCol + 1] == 1)
                                {
                                    hitCount++;
                                    m[newRow, newCol + 1] = 0;
                                }
                                if (m[newRow, newCol - 1] == 1)
                                {
                                    hitCount++;
                                    m[newRow, newCol - 1] = 0;
                                }
                                if (m[newRow - 1, newCol] == 1)
                                {
                                    hitCount++;
                                    m[newRow - 1, newCol] = 0;
                                }
                                if (m[newRow - 1, newCol + 1] == 1)
                                {
                                    hitCount++;
                                    m[newRow - 1, newCol + 1] = 0;
                                }
                                if (m[newRow - 1, newCol - 1] == 1)
                                {
                                    hitCount++;
                                    m[newRow - 1, newCol - 1] = 0;
                                }
                            }
                            if ((newCol > 0) && (newRow == 7))
                            {
                                if (m[newRow, newCol] == 1)
                                {
                                    hitCount++;
                                    m[newRow, newCol] = 0;
                                }
                                if (m[newRow, newCol + 1] == 1)
                                {
                                    hitCount++;
                                    m[newRow, newCol + 1] = 0;
                                }
                                if (m[newRow, newCol - 1] == 1)
                                {
                                    hitCount++;
                                    m[newRow, newCol - 1] = 0;
                                }
                                if (m[newRow - 1, newCol] == 1)
                                {
                                    hitCount++;
                                    m[newRow - 1, newCol] = 0;
                                }
                                if (m[newRow - 1, newCol + 1] == 1)
                                {
                                    hitCount++;
                                    m[newRow - 1, newCol + 1] = 0;
                                }
                                if (m[newRow - 1, newCol - 1] == 1)
                                {
                                    hitCount++;
                                    m[newRow - 1, newCol - 1] = 0;
                                }
                            }
                            if ((newCol == 0) && (newRow < 7 ))
                            {
                                if (m[newRow + 1, newCol] == 1)
                                {
                                    hitCount++;
                                    m[newRow + 1, newCol] = 0;
                                }
                                if (m[newRow + 1, newCol + 1] == 1)
                                {
                                    hitCount++;
                                    m[newRow + 1, newCol + 1] = 0;
                                }
                                if (m[newRow, newCol] == 1)
                                {
                                    hitCount++;
                                    m[newRow, newCol] = 0;
                                }
                                if (m[newRow, newCol + 1] == 1)
                                {
                                    hitCount++;
                                    m[newRow, newCol + 1] = 0;
                                }
                                if (m[newRow - 1, newCol] == 1)
                                {
                                    hitCount++;
                                    m[newRow - 1, newCol] = 0;
                                }
                                if (m[newRow - 1, newCol + 1] == 1)
                                {
                                    hitCount++;
                                    m[newRow - 1, newCol + 1] = 0;
                                }
                            }
                            if ((newCol == 0) && (newRow == 7))
                            {
                                if (m[newRow - 1, newCol] == 1)
                                {
                                    hitCount++;
                                    m[newRow - 1, newCol] = 0;
                                }
                                if (m[newRow - 1, newCol + 1] == 1)
                                {
                                    hitCount++;
                                    m[newRow - 1, newCol + 1] = 0;
                                }
                                if (m[newRow, newCol+1] == 1)
                                {
                                    hitCount++;
                                    m[newRow, newCol+1] = 0;
                                }
                            }
                            
                            hit = true;
                            score = score + flight * hitCount;
                            break;
                        }
                    }
                    break;
                }
                flight = 0;
                hitCount = 0;
            }
        }
        Console.Write(score);
        int countPigs = 0;
        for (int rows = 0; rows < 8; rows++)
        {
            for (int col = 0; col < 8; col++)
            {
                if (m[rows,col]==1)
                {
                    countPigs++;
                }
            }
        }
        if (countPigs == 0)
        {
            Console.WriteLine(" Yes");
        }
        else
        {
            Console.WriteLine(" No");
        }

    }
}

