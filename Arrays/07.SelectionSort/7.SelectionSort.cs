using System;

class SelectionSort
{
    static void Main()
    {
        // Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
        // Use the "selection sort" algorithm: Find the smallest element, move it at the first position, 
        // find the smallest from the rest, move it at the second position, etc.


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

        // search for smallest possible number for every element 
        for (int i = 0; i < arrayLength; i++)
        {
            int minValue = arrayOfIntegers[i];
            int minValueIndex = i;
            for (int j = i + 1; j < arrayLength; j++)
            {
                if (arrayOfIntegers[j] < minValue)
                {
                    minValue = arrayOfIntegers[j];
                    minValueIndex = j;
                }
            }
            if (minValueIndex !=i)
            {
                int tempValue = arrayOfIntegers[i];
                arrayOfIntegers[i] = arrayOfIntegers[minValueIndex];
                arrayOfIntegers[minValueIndex] = tempValue;
            }
        }
        for (int i = 0; i < arrayLength ; i++)
        {
            Console.Write("{0} ", arrayOfIntegers[i]);
        }
        Console.WriteLine();
    }
}

