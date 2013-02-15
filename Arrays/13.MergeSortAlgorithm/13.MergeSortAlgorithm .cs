using System;

class MergeSortAlgorithm
{
    // * Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

    static int[] ReadArray()
    {
        // Enter the lenght of the array and check if is entered correctly

        int arrayLength = 0;
        bool correctInput = false;
        while (!correctInput)
        {
            Console.Write("Please, enter the length of the array = ");
            correctInput = int.TryParse(Console.ReadLine(), out arrayLength);
        }
        correctInput = false;
        // enter the array while checking if the entered values are correct
        int[] arrayOfIntegers = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            while (!correctInput)
            {
                Console.Write("Array[{0}] = ", i);
                correctInput = int.TryParse(Console.ReadLine(), out arrayOfIntegers[i]);
            }
            correctInput = false;
        }
        return arrayOfIntegers;
    }
    static int[] MergeSort(int[] array)
    {
        int arrayLength = array.Length;
        if (arrayLength <= 1)
        {
            return array;
        }
        int leftArrayLength = arrayLength / 2;
        int rightArrayLength = arrayLength - leftArrayLength;
        int[] leftArray = new int[leftArrayLength];
        int[] rightArray = new int[rightArrayLength];

        // make the left and the right array
        for (int i = 0; i < leftArrayLength; i++)
        {
            leftArray[i] = array[i];
        }
        for (int i = 0, j = leftArrayLength; i < rightArrayLength; i++, j++)
        {
            rightArray[i] = array[j];
        }
        // use recursion 
        leftArray = MergeSort(leftArray);
        rightArray = MergeSort(rightArray);

        return array = SortAndMerge2Arrays(leftArray, rightArray);

    }

    static int[] SortAndMerge2Arrays(int[] leftArray, int[] rightArray)
    {

        // now we will sort and merge the left and the rigth array
        int newArrayLength = leftArray.Length + rightArray.Length;
        int[] newSortedArray = new int[newArrayLength];
        for (int i = 0, indexOfLeftArray = 0, indexOfRightArray = 0; i < newArrayLength; i++)
        {
            if (leftArray[indexOfLeftArray] <= rightArray[indexOfRightArray])
            {
                newSortedArray[i] = leftArray[indexOfLeftArray];
                indexOfLeftArray++;
                if (indexOfLeftArray == leftArray.Length)
                {
                    for (int j = i+1; j < newArrayLength; j++)
                    {
                        newSortedArray[j] = rightArray[indexOfRightArray];
                        indexOfRightArray++;
                    }
                    return newSortedArray;
                }
            }
            else if (rightArray[indexOfRightArray] < leftArray[indexOfLeftArray])
            {
                newSortedArray[i] = rightArray[indexOfRightArray];
                indexOfRightArray++;
                if (indexOfRightArray == rightArray.Length)
                {
                    for (int j = i+1; j < newArrayLength; j++)
                    {
                        newSortedArray[j] = leftArray[indexOfLeftArray];
                        indexOfLeftArray++;
                    }
                    return newSortedArray;
                }
            }
        }
        return newSortedArray;
    }
    static void PrintArray(int[] arrayForPrinting)
    {
        for (int i = 0; i < arrayForPrinting.Length-1; i++)
        {
            Console.Write("{0},", arrayForPrinting[i]);
        }
        Console.WriteLine("{0} ", arrayForPrinting[arrayForPrinting.Length-1]);
        return;
    }

    static void Main()
    {
        int[] arrayOfIntegers = ReadArray();
        int[] sortedArray = MergeSort(arrayOfIntegers);
        PrintArray(sortedArray);

    }
}
