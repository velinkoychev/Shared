// Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).


using System;
class IsTheElementBiggerThanNeighbors
{
    static bool CheckIfTheNumberIsBigger(int[] arrayOfNumbers, int numberToCheck)
    {
        bool theNumberIsBigger = true;
        if (numberToCheck - 1 >= 0)
        {
            if (arrayOfNumbers[numberToCheck] <= arrayOfNumbers[numberToCheck - 1])
            {
               return theNumberIsBigger = false;
            }
        }
        if (numberToCheck + 1 <arrayOfNumbers.Length)
        {
            if (arrayOfNumbers[numberToCheck] <= arrayOfNumbers[numberToCheck + 1])
            {
                return theNumberIsBigger = false;
            }
        }
        return theNumberIsBigger;
    }

    private static void ReadArray(out int arrayLength, out int[] arrayOfIntegers, out int numberToCheck)
    {
        // Enter the lenght of the array and check if is entered correctly

        arrayLength = 0;
        numberToCheck = 0;
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
        correctInput = false;
        while (!correctInput)
        {
            Console.Write("Please, enter the index of the number you want to check if it is bigger than its neighbours= ");
            correctInput = int.TryParse(Console.ReadLine(), out numberToCheck);
            if ((numberToCheck<0)||(numberToCheck>=arrayLength))
            {
                correctInput = false;
            }
        }
    }


    static void Main()
    {
        int arrayLength;
        int[] arrayOfIntegers;
        int numberToCheck;
        ReadArray(out arrayLength, out arrayOfIntegers, out numberToCheck);
        bool isBigger = CheckIfTheNumberIsBigger(arrayOfIntegers, numberToCheck);
        if (isBigger)
        {
            Console.WriteLine("Yes, the number is bigger than its neigbours!");
        }
        else
        {
            Console.WriteLine("No, the number is not bigger than its neigbours!");
        }
    }
}
