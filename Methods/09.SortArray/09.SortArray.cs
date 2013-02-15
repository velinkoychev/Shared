//Write a method that return the maximal element in a portion of array of integers starting at given index. 
// Using it write another method that sorts an array in ascending / descending order.


using System;
class SortArrayMethod
{
    private static int[]  ReadArray()
    {
        // Enter the lenght of the array and check if is entered correctly

        int arrayLength = 0;
        bool correctInput = false;
        while (!correctInput)
        {
            Console.Write("Please, enter the length of the array = ");
            correctInput = int.TryParse(Console.ReadLine(), out arrayLength);
        }
        // enter the array
        int [] arrayOfIntegers = new int[arrayLength];
        for (int i = 0; i<arrayLength; i++)
        {
            Console.Write("Array[{0}] = ", i);
            correctInput = int.TryParse(Console.ReadLine(), out arrayOfIntegers[i]);
        }
        return arrayOfIntegers;
    }

    private static int FindMaxElement(int startIndex, ref int[] arrayOfIntegers, ref int maxIndex)
    {
        int maxElement = arrayOfIntegers[startIndex];
        for (int i = startIndex; i < arrayOfIntegers.Length; i++)
        {
            if (arrayOfIntegers[i]>maxElement)
            {
                maxElement = arrayOfIntegers[i];
                maxIndex = i;
            }
        }
        return maxElement;
    }

    private static int[] SortArrayDescending (ref int[] arrayOfIntegers)
    {
        int maxIndex = arrayOfIntegers.Length;  ////we will use this index in order to know which elements we need to swap
        for (int i = 0; i < arrayOfIntegers.Length; i++)
        {
            int maxValue = FindMaxElement(i, ref arrayOfIntegers, ref maxIndex);
            if (maxValue != arrayOfIntegers[i])
            {
                arrayOfIntegers[maxIndex] = arrayOfIntegers[i];
                arrayOfIntegers[i] = maxValue;
            }
        }
        return arrayOfIntegers;
    }

    private static void SwapElements(ref int[] arrayOfIntegers)
    {
        // here we will reverse the array
        for (int i = 0, j= arrayOfIntegers.Length - 1; i < arrayOfIntegers.Length/2; i++, j--)
        {
            int tempElement = arrayOfIntegers[i];
            arrayOfIntegers[i] = arrayOfIntegers[j];
            arrayOfIntegers[j] = tempElement;
        }
    }
    static void Main()
    {
        int[] arrayOfIntegers= ReadArray();
        SortArrayDescending (ref arrayOfIntegers);
        Console.Write("The array sorted descending : ");
        foreach (int number in arrayOfIntegers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        SwapElements(ref arrayOfIntegers);
        Console.Write("The array sorted ascending : ");
        foreach (int number in arrayOfIntegers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}

