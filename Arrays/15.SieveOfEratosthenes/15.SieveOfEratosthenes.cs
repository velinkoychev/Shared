using System;
class SieveOfEratosthenes
{
    static void Main()
    {
        bool[] arrayOfNumbers = new bool[10000001]; //create an array with 10 000 001 bool elements (all are them a false)
        Console.Write("1 ");
        for (int i = 2; i < arrayOfNumbers.Length; i++)
        {
            if (arrayOfNumbers[i] == false)
            {
                Console.Write(i + " ");
                for (int j = i, z=1; j < arrayOfNumbers.Length; j=i*z, z++)
                {
                    arrayOfNumbers[j] = true;
                }
            }
        }
    }
}

