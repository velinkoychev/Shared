using System;
class OutputMatrix
{
    static void Main()
    {
        byte n;
        bool correctInput;
        do
        {
            Console.Write("Please, write number N (0<N<20) = ");
            correctInput = byte.TryParse(Console.ReadLine(), out n);
            if ((n >= 20) && (n<=0))
            {
                correctInput = false;
            }
        }
        while (!correctInput);

        byte[] numberOfMatrix = new byte[n];
        for (byte i = 0; i < n; i++)
        {
            numberOfMatrix[i] = Convert.ToByte (i+1);
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
			{
                Console.Write(" "+ numberOfMatrix[j] + " ");
                numberOfMatrix[j] = Convert.ToByte(numberOfMatrix[j] + 1);
			}
            Console.WriteLine();
            
        }
    }
}

