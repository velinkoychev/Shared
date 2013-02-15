// Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

using System;
class APrintsMatrix
{


    static void Main()
    {
        int numberN;
        int[,] matrix;
        int row = 0;
        int col = 0;
        int counter = 1; //counting how many cells were already entered. We do this in order to know when do we have to end entering numbers
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
        matrix = new int[numberN, numberN];
        matrix[0, 0] = 1;

        for (int colF = 0; colF < numberN; colF++) // enter the numbers in the matrix array
        {
            for (int rowF = 0; rowF < numberN; rowF++)
            {
                matrix[rowF, colF] = counter;
                counter++;
            }
        }
        for (row = 0; row < numberN; row++)  // print the array
        {
            for (col = 0; col < numberN; col++)
            {
                Console.Write("{0,5}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}