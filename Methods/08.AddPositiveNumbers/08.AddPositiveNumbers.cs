//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
//Each of the numbers that will be added could have up to 10 000 digits.


using System;
using System.Collections.Generic;
class AddPositiveNumbers
{
    static int[] AddNumbers(int[] number1, int[] number2)
    {
        int lengthOfArray = Math.Max(number1.Length, number2.Length);
        int[] sumOfNumbers = new int[lengthOfArray + 1];
        for (int i = 0; i < sumOfNumbers.Length - 1; i++)
        {
            int tempSum = sumOfNumbers[i];
            // we want to make sure that there is a digit in the number at this index
            if (i < number1.Length)
            {
                tempSum = tempSum + number1[i];
            }
            if (i < number2.Length)
            {
                tempSum = tempSum + number2[i];
            }
            sumOfNumbers[i] = tempSum % 10;
            sumOfNumbers[i + 1]=tempSum / 10;

        }
        return sumOfNumbers;
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
        for (int i = arrayLength - 1; i>=0; i--)
        {
            Console.Write("Array[{0}] = ", i);
            correctInput = int.TryParse(Console.ReadLine(), out arrayOfIntegers[i]);
        }
    }
    static void Main()
    {
        int[] number1 = { 1, 0, 1, 0 };
        int[] number2 = { 9, 0, 9, 0 };
        int[] sumNumber = AddNumbers(number1, number2);
        Console.Write("The sum of the two numbers = ");
        if (sumNumber[sumNumber.Length-1]!=0)
        {
            Console.Write(sumNumber[sumNumber.Length - 1]);
        }
        for (int i = sumNumber.Length - 2; i >= 0; i--)
        {
            Console.Write(sumNumber[i]);
        }
        Console.WriteLine();
        int number1Length;
        int number2Length;
        ReadArray(out number1Length, out number1);
        ReadArray(out number2Length, out number2);
        sumNumber = AddNumbers(number1, number2);
        Console.Write("The sum of the two numbers = ");
        if (sumNumber[sumNumber.Length - 1] != 0)
        {
            Console.Write(sumNumber[sumNumber.Length - 1]);
        }
        for (int i = sumNumber.Length - 2; i >= 0; i--)
        {
            Console.Write(sumNumber[i]);
        }
        Console.WriteLine();
    }
}

