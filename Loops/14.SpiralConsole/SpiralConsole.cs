using System;
class SpiralConsole
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
            Console.Write("Please, write number N (0<N<20) = ");
            correctInput = int.TryParse(Console.ReadLine(), out numberN);
            if ((numberN >= 20) && (numberN <= 0))
            {
                correctInput = false;
            }
        }
        while (!correctInput);
        spiral = new int[numberN, numberN];
        spiral[0, 0] = 1;
        while (counter != numberN * numberN)
        {
            Right();
            Down();
            Left();
            Up();
        }
        for (row = 0; row < numberN; row++)
        {
            for (col = 0; col < numberN; col++)
            {
                Console.Write(spiral[row, col] + "  ");
            }
            Console.WriteLine();
        }
    }
}
