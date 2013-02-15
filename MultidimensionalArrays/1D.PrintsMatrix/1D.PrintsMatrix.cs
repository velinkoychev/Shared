// Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)


using System;
class DPrintsMatrix
{
    static int numberN;
    static int[,] spiral;
    static byte row = 0;
    static byte col = 0;
    static int counter = 1; //counting how many cells were already entered. We do this in order to know when do we have to end entering numbers
    static int lastNumber = 1;
    static void Right() // spiral going in right direction
    {
        while ((col < numberN - 1) && (spiral[row, col + 1] == 0))
        {
            col++;
            spiral[row, col] = lastNumber + 1;
            lastNumber++;
            counter++;
        }
    }
    static void Down() // spiral going in down direction
    {
        while ((row < numberN - 1) && (spiral[row + 1, col] == 0))
        {
            row++;
            spiral[row, col] = lastNumber + 1;
            lastNumber++;
            counter++;
        }
    }
    static void Left() // spiral going in left direction
    {
        while ((col > 0) && (spiral[row, col - 1] == 0))
        {
            col--;
            spiral[row, col] = lastNumber + 1;
            lastNumber++;
            counter++;
        }
    }
    static void Up() // spiral going in up direction
    {
        while ((row > 0) && (spiral[row - 1, col] == 0))
        {
            row--;
            spiral[row, col] = lastNumber + 1;
            lastNumber++;
            counter++;
        }
    }
    static void Main()
    {
        bool correctInput;
        do  //enter number N correctly
        {
            Console.Write("Please, write number N (N>0) = ");
            correctInput = int.TryParse(Console.ReadLine(), out numberN);
            if (numberN <= 0)
            {
                correctInput = false;
            }
        }
        while (!correctInput);
        spiral = new int[numberN, numberN];
        spiral[0, 0] = 1;
        while (counter != numberN * numberN)
        {
            
            Down();
            Right();
            Up();
            Left();
            
        }
        for (row = 0; row < numberN; row++)
        {
            for (col = 0; col < numberN; col++)
            {
                Console.Write("{0,5}",spiral[row, col]);
            }
            Console.WriteLine();
        }
    }
}