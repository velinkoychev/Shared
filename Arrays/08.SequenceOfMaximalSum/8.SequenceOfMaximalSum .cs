using System;
class SequenceOfMaximalSum 
{
    static void Main()
    {
        // Write a program that finds the sequence of maximal sum in given array. Example:
        //{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
        //Can you do it with only one loop (with single scan through the elements of the array)?

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

        int bestSum = arrayOfIntegers[0];
        int bestStart = 0;
        int bestEnd = 0;
        int start = 0;
        int sum = arrayOfIntegers[0];
        for (int i = 1; i < arrayLength; i++)
        {
            sum = sum + arrayOfIntegers[i];
            if (sum > bestSum)
            {
                bestSum = sum;
                bestStart = start;
                bestEnd = i;
            }
            else if (sum<0)
            {
                sum = 0;
                if (i+1<arrayLength)
                {
                    start = i + 1;
                }
            }
        }
        // print the answer
        Console.Write("The maximal sum = {0} and it is ",bestSum);
        for (int i = bestStart; i <= bestEnd ; i++)
        {
            Console.Write("{0} ", arrayOfIntegers[i]);
        }
        Console.WriteLine();


    }
}

