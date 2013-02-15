using System;
class QuickSort
{

    // Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).


    static string[] ReadArray()
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
        string[] arrayOfStrings = new string[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {   
            Console.Write("Array[{0}] = ", i);
            arrayOfStrings[i] = Console.ReadLine();
        }
        return arrayOfStrings;

    }

    static string[] QuickSortArray(string[] array)
    {
        if (array.Length <= 1)
        {
            return array;
        }
        else if (array.Length == 2)
        {
            if (string.Compare(array[0], array[1]) <= 0)
            {
                return array;
            }
            else
            {
                Array.Reverse(array); //switch their places
                return array;
            }
        }
        else
        {
            int pivot = array.Length / 2;
            int elementsBeforePivot = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (string.Compare(array[i], array[pivot]) <= 0) //we will include the pivot to the left array
                {
                    elementsBeforePivot++;
                }
            }
            string[] leftArray = new string[elementsBeforePivot];
            string[] rightArray = new string[array.Length - elementsBeforePivot];
            int leftArrayCounter = 0;
            int rightArrayCounter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (string.Compare(array[i], array[pivot]) <= 0)
                {
                    leftArray[leftArrayCounter] = array[i];
                    leftArrayCounter++;
                }
                else
                {
                    rightArray[rightArrayCounter] = array[i];
                    rightArrayCounter++;
                }

            }
            // use recursion 
            leftArray = QuickSortArray(leftArray);
            rightArray = QuickSortArray(rightArray);

            return array = Merge2Arrays(leftArray, rightArray);
        }
    }

    static string[] Merge2Arrays(string[] leftArray, string[] rightArray)
    {

        // now we will merge the left and the rigth array
        string[] newArray = new string[leftArray.Length + rightArray.Length];
        for (int i = 0; i < leftArray.Length; i++)
        {
            newArray[i] = leftArray[i];
        }
        for (int i = leftArray.Length, j = 0; i < newArray.Length; i++, j++)
        {
            newArray[i] = rightArray[j];
        }
        return newArray;
    }
    static void PrintArray(string[] arrayForPrinting)
    {
        for (int i = 0; i < arrayForPrinting.Length - 1; i++)
        {
            Console.Write("{0},", arrayForPrinting[i]);
        }
        Console.WriteLine("{0} ", arrayForPrinting[arrayForPrinting.Length - 1]);
        return;
    }

    static void Main()
    {
        string[] arrayOfStrings = ReadArray();
        string[] sortedArray = QuickSortArray(arrayOfStrings);
        PrintArray(sortedArray);

    }
}
