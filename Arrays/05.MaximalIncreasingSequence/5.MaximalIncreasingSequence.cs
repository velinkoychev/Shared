using System;
class MaximalIncreasingSequence
{
    static void Main()
    {
        //Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

        
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
        int counterOfElements = 1;
        int bestCountOfElements = 1;
        int bestStartIndex = 0;
        int startIndex = 0;
        for (int i = 1; i < arrayLength; i++)
        {
            if (arrayOfIntegers[i] > arrayOfIntegers[i - 1])
            {
                counterOfElements++;
            }
            if ((arrayOfIntegers[i] <= arrayOfIntegers[i - 1]) || (i == arrayLength - 1))
            {
                if (counterOfElements > bestCountOfElements)
                {
                    bestCountOfElements = counterOfElements;
                    bestStartIndex = startIndex;
                    counterOfElements = 1;
                    startIndex = i;
                }
                else
                {
                    counterOfElements = 1;
                    startIndex = i;
                }
            }
        }
        Console.WriteLine("The maximal sequence of increasing  elements in the array consist {0} elements  and  it is: ", bestCountOfElements);
        for (int i = bestStartIndex; i < bestStartIndex + bestCountOfElements; i++)
        {
            Console.Write("{0} ", arrayOfIntegers[i]);
        }
        Console.WriteLine();
    }
}

