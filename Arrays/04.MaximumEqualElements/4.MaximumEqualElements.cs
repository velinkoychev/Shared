using System;
class MaximumEqualElements
{
    static void Main()
    {
        //Write a program that finds the maximal sequence of equal elements in an array.


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
        int counterOfEqualElements = 1;
        int bestCountOfEqualElements = 1;
        int bestStartIndex = 0;
        int startIndex = 0;
        for (int i = 1; i < arrayLength; i++)
        {
            if (arrayOfIntegers[i]==arrayOfIntegers[i-1])
            {
                counterOfEqualElements++;
            }
            if ((arrayOfIntegers[i] != arrayOfIntegers[i - 1])||(i==arrayLength -1))
            {
                if (counterOfEqualElements > bestCountOfEqualElements)
                {
                    bestCountOfEqualElements = counterOfEqualElements;
                    bestStartIndex = startIndex;
                    counterOfEqualElements = 1;
                    startIndex = i;
                }
                else 
                {
                    counterOfEqualElements = 1;
                    startIndex = i;
                }
            }
        }
        Console.WriteLine("The maximal sequence of equal elements in the array consist {0} elements  and  it is: ", bestCountOfEqualElements);
        for (int i = bestStartIndex; i < bestStartIndex + bestCountOfEqualElements; i++)
        {
            Console.Write("{0} ", arrayOfIntegers[i]);
        }
        Console.WriteLine();
    }
}

