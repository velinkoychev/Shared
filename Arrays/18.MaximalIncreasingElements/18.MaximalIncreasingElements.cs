// * Write a program that reads an array of integers and removes from it a minimal number of elements 
// in such way that the remaining array is sorted in increasing order. Print the remaining sorted array. Example:
//	{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}


using System;
using System.Collections.Generic;

class MaximalIncreasingElements
{
    static void Main()
    {
        int arrayLength;
        int[] arrayOfIntegers;
        ReadArray(out arrayLength, out arrayOfIntegers);
        SearchForSubset(arrayLength, arrayOfIntegers);

    }

    private static void ReadArray(out int arrayLength, out int[] arrayOfIntegers)
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
    }

    private static void SearchForSubset(int arrayLength, int[] arrayOfIntegers)
    {
        List<int> bestList = new List<int> ();
        List<int> tempList = new List<int> ();
        for (int i = 1; i <= (Math.Pow(2, arrayLength) - 1); i++)
        {
            tempList.Clear();
            int lastIndex = int.MinValue;
            for (int j = 0; j < arrayLength; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if ((bit == 1)&&((lastIndex==int.MinValue)||(arrayOfIntegers[j]>=arrayOfIntegers[lastIndex]))) //conditions to add a number to the list
                {
                    tempList.Add(arrayOfIntegers[j]);
                    lastIndex = j;
                }
            }
            if (tempList.Count > bestList.Count)
            {
                bestList.Clear();
                for (int z = 0; z < tempList.Count; z++)
                {
                    bestList.Add(tempList[z]);
                }
            }

        }
        for (int i = 0; i < bestList.Count; i++) // Print the best list
        {
            Console.WriteLine(bestList[i]);
        }

        return;
    }
}

