//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets 
//of several neighbor elements located on the same line, column or diagonal. 
//Write a program that finds the longest sequence of equal strings in the matrix. 

using System;

class LongestSequence
{
    static string bestElement = "";
    static int bestCount = 1;
    static int currentCount = 1;
    static int numberN, numberM;
    
    
    static void Main()
    {
        bool correctInput;
        do  ////enter number N correctly
        {
            Console.Write("Please, write number N (N>0) = ");
            correctInput = int.TryParse(Console.ReadLine(), out numberN);
            if (numberN <= 0)
            {
                correctInput = false;
            }
        }
        while (!correctInput);
        correctInput = false;
        do  ////enter number M correctly
        {
            Console.Write("Please, write number M (M>0) = ");
            correctInput = int.TryParse(Console.ReadLine(), out numberM);
            if (numberM <= 0)
            {
                correctInput = false;
            }
        }
        while (!correctInput);
        string[,] matrix = new string[numberN, numberM];

        // enter matrix elements
        for (int row = 0; row < numberN; row++)
        {
            for (int col = 0; col < numberM; col++)
            {
                do  ////enter the strings
                {
                    Console.Write("Please, write Matrix [{0},{1}] = ", row, col);
                    matrix[row, col] = Console.ReadLine();
                }
                while (!correctInput);
            }
        }
        Rows(matrix);
        Cols(matrix);
        Diagonals(matrix);
        Console.Write("The longest sequence of equal strings in the matrix is: ");
        for (int i = 0; i < bestCount; i++)
        {
            Console.Write("{0} ", bestElement);
        }
        Console.WriteLine();
    }
    static void Rows(string[,] matrix)
    {
        for (int rows = 0; rows < numberN; rows++)
        {
            for (int cols = 1; cols < numberM; cols++)
            {
                if (matrix[rows, cols - 1] == matrix[rows, cols])
                {
                    currentCount++;
                }
                if ((matrix[rows, cols - 1] != matrix[rows, cols])||(cols==numberM -1))
                {
                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        bestElement = matrix[rows, cols - 1];
                    }
                    currentCount = 1;
                }
            }
        }
    }
    static void Cols(string[,] matrix)
    {
        for (int cols = 0; cols < numberM; cols++)
        {
            for (int rows = 1; rows < numberN; rows++)
            {
                if (matrix[rows - 1, cols] == matrix[rows, cols])
                {
                    currentCount++;
                }
                if ((matrix[rows - 1, cols] != matrix[rows, cols]) || (rows == numberN - 1))
                {
                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        bestElement = matrix[rows - 1, cols];
                    }
                    currentCount = 1;
                }
            }
        }
    }
    static void Diagonals ( string[,] matrix )
    {
        for (int rows = 1; rows < numberN-1; rows++)
        {
            int col = 1;
            int row = rows;
            currentCount = 1;
            while ((col < numberM)&&(row <numberN))
            {
                if (matrix[row, col] == matrix [row - 1, col - 1] )
                {
                    currentCount++;
                }
                if ((matrix[row, col] != matrix[row - 1, col - 1]) || (col == numberM - 1) || (row == numberN - 1))
                {
                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        bestElement = matrix[row - 1, col-1];
                    }
                    currentCount = 1;
                }
                col++;
                row++;
            }
        }

        for (int rows = 1; rows < numberN - 1; rows++)
        {
            int col = numberM - 2;
            int row = rows;
            currentCount = 1;
            while ((col >= 0) && (row < numberN))
            {
                if (matrix[row, col] == matrix[row - 1, col + 1])
                {
                    currentCount++;
                }
                if ((matrix[row, col] != matrix[row - 1, col + 1]) || (col == 0) || (row == numberN - 1))
                {
                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        bestElement = matrix[row - 1, col + 1];
                    }
                    currentCount = 1;
                }
                col--;
                row++;
            }
        }
        for (int cols = 1; cols < numberM - 1; cols++)
        {
            int row = 1;
            int col = cols;
            currentCount = 1;
            while ((col < numberM) && (row < numberN))
            {
                if (matrix[row, col] == matrix[row - 1, col - 1])
                {
                    currentCount++;
                }
                if ((matrix[row, col] != matrix[row - 1, col - 1]) || (col == numberM - 1) || (row == numberN - 1))
                {
                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        bestElement = matrix[row - 1, col - 1];
                    }
                    currentCount = 1;
                }
                col++;
                row++;
            }
        }

        for (int cols = numberM-2; cols >=0; cols--)
        {
            int col = cols;
            int row = 1;
            currentCount = 1;
            while ((col >= 0) && (row < numberN))
            {
                if (matrix[row, col] == matrix[row - 1, col + 1])
                {
                    currentCount++;
                }
                if ((matrix[row, col] != matrix[row - 1, col + 1]) || (col == 0) || (row == numberN - 1))
                {
                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        bestElement = matrix[row - 1, col + 1];
                    }
                    currentCount = 1;
                }
                col--;
                row++;
            }
        }
    }
}
