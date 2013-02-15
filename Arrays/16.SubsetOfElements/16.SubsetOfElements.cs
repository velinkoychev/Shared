

//* We are given an array of integers and a number S.
// Write a program to find if there exists a subset of the elements of the array that has a sum S. 
// Example: arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)



using System;

class SubsetOfElements
{
    static void Main()
    {
        int arrayLength;
        int[] arrayOfIntegers;
        int numberS;
        ReadArray(out arrayLength, out arrayOfIntegers, out numberS);
        SearchForSubset(arrayLength, arrayOfIntegers, numberS);

    }

    private static void ReadArray(out int arrayLength, out int[] arrayOfIntegers, out int numberS)
    {
        // Enter the lenght of the array and check if is entered correctly

        arrayLength = 0;
        bool correctInput = false;
        while (!correctInput)
        {
            Console.Write("Please, enter the length of the array = ");
            correctInput = int.TryParse(Console.ReadLine(), out arrayLength);
        }
        // enter the array
        arrayOfIntegers = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Array[{0}] = ", i);
            correctInput = int.TryParse(Console.ReadLine(), out arrayOfIntegers[i]);
        }
        numberS = 0;
        correctInput = false;

        // enter number S
        while (!correctInput)
        {
            Console.Write("Please, enter number S = ");
            correctInput = int.TryParse(Console.ReadLine(), out numberS);
        }
    }

    private static void SearchForSubset(int arrayLength, int[] arrayOfIntegers, int numberS)
    {
        bool thereIsNoAnswer = true;
        for (int i = 1; i <= (Math.Pow(2, arrayLength) - 1); i++)
        {
            string sumSNumbers = "";
            int sumS = 0;
            for (int j = 0; j < arrayLength; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    sumS = sumS + arrayOfIntegers[j];
                    sumSNumbers = sumSNumbers + " " + arrayOfIntegers[j];
                    if (sumS == numberS)
                    {
                        Console.WriteLine("Yes, there is such subset ==> {0}", sumSNumbers);
                        thereIsNoAnswer = false;
                        return;
                    }
                }
            }


        }
        if (thereIsNoAnswer)
        {
            Console.WriteLine("There is no such a subset");
        }
        return;
    }
}

