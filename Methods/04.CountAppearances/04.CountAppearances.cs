//Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.


using System;
using System.Collections.Generic;
class CountAppearancesMethod
{
    static int CountAppearances(int[] arrayOfNumbers, int numberToCheck)
    {
        int countAppearances = 0;
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            if (arrayOfNumbers[i] == numberToCheck)
            {
                countAppearances++;
            }
        }
        return countAppearances;
    }

    private static void ReadArray(out int arrayLength, out int[] arrayOfIntegers,out int numberToCheck)
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
            Console.Write("Please, enter the number you want to check how many times it appears = ");
            correctInput = int.TryParse(Console.ReadLine(), out numberToCheck );
        }
    }

    static void Main()
    {
        int arrayLength;
        int[] arrayOfIntegers;
        int numberToCheck;
        ReadArray(out arrayLength, out arrayOfIntegers, out numberToCheck);
        int counter = CountAppearances(arrayOfIntegers, numberToCheck);
        Console.WriteLine("The number appearce {0} times in the array" , counter);
    }
}
