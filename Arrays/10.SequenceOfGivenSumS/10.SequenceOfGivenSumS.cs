using System;

class SequenceOfGivenSumS
{
    static void Main()
    {
        //Write a program that finds in given array of integers a sequence of given sum S (if present). 
        //Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

        // Enter the lenght of the array and check if is entered correctly

        int arrayLength = 0;
        int sumS = int.MinValue;
        bool correctInput = false;
        while (!correctInput)
        {
            Console.Write("Please, enter the length of the array = ");
            correctInput = int.TryParse(Console.ReadLine(), out arrayLength);
        }
        correctInput = false;
        while (!correctInput)
        {
            Console.Write("Please, enter sum S = ");
            correctInput = int.TryParse(Console.ReadLine(), out sumS);
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

        int startValue = int.MinValue;
        int endValue = int.MinValue;
        int sum = int.MinValue;
        SearchForSumS(arrayLength, sumS, arrayOfIntegers, ref startValue, ref endValue, ref sum);
        if (startValue != int.MinValue)
        {
            for (int i = startValue; i <= endValue; i++)
            {
                Console.Write("{0} ", arrayOfIntegers[i]);
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("There is not such a sequence");
        }
    }

    private static void SearchForSumS(int arrayLength, int sumS, int[] arrayOfIntegers, ref int startValue, ref int endValue, ref int sum)
    {
        for (int i = 0; i < arrayLength; i++)
        {
            sum = 0;
            for (int j = i; j < arrayLength; j++)
            {
                sum = sum + arrayOfIntegers[j];
                if (sum == sumS)
                {
                    startValue = i;
                    endValue = j;
                    return;
                }
                if (sum > sumS)
                {
                    break;
                }
            }
        }
    }
}

