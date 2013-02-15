// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class RectangularMatrix
{
    static void Main()
    {
        int numberN, numberM;
        bool correctInput;
        do  ////enter number N correctly
        {
            Console.Write("Please, write number N (N>2) = ");
            correctInput = int.TryParse(Console.ReadLine(), out numberN);
            if (numberN <= 2)
            {
                correctInput = false;
            }
        }
        while (!correctInput);
        correctInput = false;
        do  ////enter number M correctly
        {
            Console.Write("Please, write number M (M>2) = ");
            correctInput = int.TryParse(Console.ReadLine(), out numberM);
            if (numberM <= 2)
            {
                correctInput = false;
            }
        }
        while (!correctInput);
        int[,] matrix = new int[numberN, numberM];

        // enter matrix elements
        for (int row = 0; row < numberN; row++)
        {
            for (int col = 0; col < numberM; col++)
            {
                do  //// enter the number correctly
                {
                    Console.Write("Please, write Matrix [{0},{1}] = ",row,col);
                    correctInput = int.TryParse(Console.ReadLine(), out matrix[row,col]);   
                }
                while (!correctInput);
            }
        }
        int bestUpperLeftCornerRow = 0;
        int bestUpperLeftCornerCol = 0;
        int bestSum = int.MinValue;
        int currentSum = int.MinValue;
        for (int row = 0; row < numberN-2; row++)
        {
            for (int col = 0; col < numberM - 2; col++)
            {
                // calculate the sum of these 9 cells
                currentSum = int.MinValue;
                currentSum = matrix[row, col] + matrix[row, col+1] + matrix[row, col+2];
                currentSum = currentSum + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2];
                currentSum = currentSum + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                //check if this sum is bigger than the previous best sum
                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestUpperLeftCornerRow = row;
                    bestUpperLeftCornerCol = col;
                }
            }
        }
        Console.WriteLine("The best sum = {0}", bestSum);
        for (int row = bestUpperLeftCornerRow, counter=0 ; counter < 3; row++, counter ++)
        {
            for (int col = bestUpperLeftCornerCol, counter2=0; counter2 < 3; col++, counter2 ++)
            {
                Console.Write("{0,4}", matrix[row,col]);
            }
            Console.WriteLine();
        }

    }
}
