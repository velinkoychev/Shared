//* Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size. 

using System;
class LargestAreaOfEqualNeighborElements
{
    static int bestCount = 0;
    static int bestElement = int.MinValue;
    static int currentCount = 0;
    static int[,] matrix;  //// matrix with the elements
    static bool[,] matrixVisitedElements; ////another matrix with bool elements to keep track of which elements we have already visited


    // we will use recursion 
    static void SearchForEqualElements(int rowLocation, int colLocation)
    {
        currentCount = currentCount + 1;
        matrixVisitedElements[rowLocation, colLocation] = true;
        for (int i = -1; i < 2; i = i + 2)
        {
            if (IsThereCell(rowLocation + i, colLocation))
            {
                if (matrix[rowLocation, colLocation] == matrix[rowLocation + i, colLocation])
                {
                    SearchForEqualElements(rowLocation + i, colLocation);
                }
            }
        }
        for (int i = -1; i < 2; i = i + 2)
        {
            if (IsThereCell(rowLocation, colLocation + i))
            {
                if (matrix[rowLocation, colLocation] == matrix[rowLocation, colLocation + i])
                {
                    SearchForEqualElements(rowLocation, colLocation + i );
                }
            }
        }
    }
    // we want to check if the cell exist and if it exist is it already visited.
    static bool IsThereCell(int rowLocation, int colLocation)
    {
        bool isThereCell = ((rowLocation >= 0) && (colLocation >= 0) && (rowLocation < matrix.GetLength(0)) && (colLocation < matrix.GetLength(1)));
        if (isThereCell)
        {
            if (matrixVisitedElements[rowLocation, colLocation] == true)
            {
                isThereCell = false;
            }
        }
        return isThereCell;
    }
    static void Main()
    {
        int numberN, numberM;
        bool correctInput;
        do  ////enter number N correctly
        {
            Console.Write("Please, write number N, the rows of the rectangular matrix  (N>0) = ");
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
            Console.Write("Please, write number M,the cols of the rectangular matrix   (M>0) = ");
            correctInput = int.TryParse(Console.ReadLine(), out numberM);
            if (numberM <= 0)
            {
                correctInput = false;
            }
        }
        while (!correctInput);
        matrix = new int[numberN, numberM];

        // enter matrix elements
        for (int row = 0; row < numberN; row++)
        {
            for (int col = 0; col < numberM; col++)
            {
                do  //// enter the number correctly
                {
                    Console.Write("Please, write Matrix [{0},{1}] = ", row, col);
                    correctInput = int.TryParse(Console.ReadLine(), out matrix[row, col]);
                }
                while (!correctInput);
            }
        }
        matrixVisitedElements = new bool[numberN, numberM];
        for (int rowLocation = 0; rowLocation < numberN; rowLocation++)
        {
            for (int colLocation = 0; colLocation < numberM; colLocation++)
            {
                if (!matrixVisitedElements[rowLocation, colLocation])
                {
                    SearchForEqualElements(rowLocation, colLocation);
                }
                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                    bestElement = matrix[rowLocation, colLocation];
                }
                currentCount = 0;
            }
        }
        Console.WriteLine("There are {0} times of {1}", bestCount, bestElement);
    }
}

