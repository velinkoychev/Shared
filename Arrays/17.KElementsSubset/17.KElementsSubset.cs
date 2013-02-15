//* Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
//Find in the array a subset of K elements that have sum S or indicate about its absence.


using System;
class KElementsSubset
{
    static void Main()
    {
        int arrayLength;
        int[] arrayOfIntegers;
        int numberS;
        int numberK;
        ReadArray(out arrayLength, out arrayOfIntegers, out numberS, out numberK);
        SearchForSubset(arrayLength, arrayOfIntegers, numberS, numberK);

    }

    private static void ReadArray(out int arrayLength, out int[] arrayOfIntegers, out int numberS, out int numberK)
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
            Console.Write("Please, enter Sum S = ");
            correctInput = int.TryParse(Console.ReadLine(), out numberS);
        }
        numberK = 0;
        correctInput = false;

        // enter number K
        while (!correctInput)
        {
            Console.Write("Please, enter number K = ");
            correctInput = int.TryParse(Console.ReadLine(), out numberK);
        }
    }

    private static void SearchForSubset(int arrayLength, int[] arrayOfIntegers, int numberS, int numberK)
    {
        bool thereIsNoAnswer = true;
        for (int i = 1; i <= (Math.Pow(2, arrayLength) - 1); i++)
        {
            string sumSNumbers = "";
            int sumS = 0;
            int counterOfNumbers = 0;
            for (int j = 0; j < arrayLength; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    sumS = sumS + arrayOfIntegers[j];
                    sumSNumbers = sumSNumbers + " " + arrayOfIntegers[j];
                    counterOfNumbers++;
                    if ((sumS == numberS) && (counterOfNumbers == numberK))
                    {
                        Console.WriteLine("Yes, there is such subset ==> {0}", sumSNumbers);
                        thereIsNoAnswer = false;
                        return;
                    }
                    if (counterOfNumbers > numberK)
                    {
                        break;
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

