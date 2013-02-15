using System;
using System.Threading;
using System.Globalization;
using System.Numerics;

class Problem2
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        BigInteger q4 = BigInteger.Parse(Console.ReadLine());
        BigInteger q3 = BigInteger.Parse(Console.ReadLine());
        BigInteger q2 = BigInteger.Parse(Console.ReadLine());
        BigInteger q1 = BigInteger.Parse(Console.ReadLine());
        BigInteger nextQNumber = 0;
        BigInteger tempNumber = 0;
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());
        BigInteger[] matrix = new BigInteger[rows * columns];
        matrix [0]= q4;
        matrix [1]= q3;
        matrix [2]= q2;
        matrix [3]= q1;
        for (int i = 4; i < rows*columns; i++)
			{
			 matrix [i] = matrix [i-1]+matrix [i-2]+matrix [i-3]+matrix [i-4];
			}
        int counter = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[counter]);
                Console.Write(" ");
                counter++;
            }
            Console.WriteLine();
        }


    }
}

