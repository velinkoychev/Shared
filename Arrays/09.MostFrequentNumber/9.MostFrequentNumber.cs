using System;

class MostFrequentNumber
{
    static void Main()
    {
        //    Write a program that finds the most frequent number in an array. Example:
        //{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

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

        // to make things easier we will sort the array
        Array.Sort(arrayOfIntegers);
        int counterOfEqualElements=1;
        int bestCount=1;
        int bestNumber = arrayOfIntegers[0];
        for (int i = 1; i < arrayLength ; i++)
        {
            if (arrayOfIntegers[i] == arrayOfIntegers[i - 1])
            {
                counterOfEqualElements++;
                if (counterOfEqualElements > bestCount)
                {
                    bestCount = counterOfEqualElements;
                    bestNumber = arrayOfIntegers[i];
                }
            }
            else
            {
                counterOfEqualElements = 1;
            }
        }

        // print the answer

        Console.WriteLine("There are {0} times of number {1}", bestCount, bestNumber);
    }
}
