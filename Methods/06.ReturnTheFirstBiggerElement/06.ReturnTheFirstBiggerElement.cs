//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
// Use the method from the previous exercise.


using System;
class ReturnTheFirstBiggerElement
{
    static int CheckIfTheNumberIsBigger(int[] arrayOfNumbers)
    {
        for (int i = 0; i < arrayOfNumbers.Length; i++)
			{
                if (i - 1 >= 0)
                {
                    if (arrayOfNumbers[i] <= arrayOfNumbers[i - 1])
                    {
                        continue;
                    }
                }
                if (i + 1 < arrayOfNumbers.Length)
                {
                    if (arrayOfNumbers[i] <= arrayOfNumbers[i + 1])
                    {
                        continue;
                    }
                }
                return i;
			}
        return -1;
    }

    private static void ReadArray(out int arrayLength, out int[] arrayOfIntegers)
    {
        // Enter the lenght of the array and check if is entered correctly

        arrayLength = 0;
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
    }


    static void Main()
    {
        int arrayLength;
        int[] arrayOfIntegers;
        ReadArray(out arrayLength, out arrayOfIntegers);
        int indexOfElement = CheckIfTheNumberIsBigger(arrayOfIntegers);
        Console.WriteLine("The index of the element is {0} ", indexOfElement);
        
    }
}
