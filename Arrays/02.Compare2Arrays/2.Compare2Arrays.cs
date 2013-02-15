using System;
class Compare2Arrays
{
    static void Main()
    {
        // Write a program that reads two arrays from the console and compares them element by element

        // Enter the lenght of the arrays and check if they are entered correctly
        int arrayLength1 = 0;
        int arrayLength2 = 0;
        bool correctInput = false;
        bool equalArrays = true;
        bool firstArrayIsBigger = false;
        bool secondArrayIsBigger = false;
        while (!correctInput)  
        {
            Console.Write("Please, enter the length of the 1st array = ");
            correctInput = int.TryParse(Console.ReadLine(), out arrayLength1);
        }
        correctInput = false;
        while (!correctInput)
        {
            Console.Write("Please, enter the length of the 2nd array = ");
            correctInput = int.TryParse(Console.ReadLine(), out arrayLength2);
        }
        correctInput = false;
        // enter the 2 arrays while checking if the entered values are correct
        int[] arrayOfIntegers = new int[arrayLength1];
        int[] arrayOfIntegers2 = new int[arrayLength2];
        for (int i = 0; i < arrayLength1; i++)
        {
            while (!correctInput)
            {
                Console.Write("Array1[{0}] = ", i);
                correctInput = int.TryParse(Console.ReadLine(), out arrayOfIntegers[i]);
            }
            correctInput = false;
        }
        for (int i = 0; i < arrayLength2; i++)
        {
            while (!correctInput)
            {
                Console.Write("Array1[{0}] = ", i);
                correctInput = int.TryParse(Console.ReadLine(), out arrayOfIntegers2[i]);
            }
            correctInput = false;
        }
           // comparing them element by element, but only till their common length
        int minLength = Math.Min(arrayLength1, arrayLength2);
        for (int i = 0; i < minLength ; i++)
        {
            if (arrayOfIntegers[i]==arrayOfIntegers2[i])
            {
                Console.WriteLine("The {0} element of the both arrays are equal", i);
            }
            if (arrayOfIntegers[i] > arrayOfIntegers2[i])
            {
                Console.WriteLine("The {0} element of the 1st array is bigger than the {0} element of the 2nd", i);
                if (equalArrays)
                {
                    firstArrayIsBigger = true;
                    equalArrays = false;
                }
            }
            if (arrayOfIntegers[i] < arrayOfIntegers2[i])
            {
                Console.WriteLine("The {0} element of the 1st array is smaller than the {0} element of the 2nd", i);
                if (equalArrays)
                {
                    secondArrayIsBigger = true;
                    equalArrays = false;
                }
            }
        }
        if (arrayLength1 > arrayLength2 )
        {
            Console.WriteLine("The 1st array has also {0} more elements than the 2nd array", arrayLength1 - arrayLength2);
            if (equalArrays)
            {
                firstArrayIsBigger = true;
                equalArrays = false;
            }
        }
        if (arrayLength1 < arrayLength2)
        {
            Console.WriteLine("The 2nd array has also {0} more elements than the 1nd array", arrayLength2 - arrayLength1);
            if (equalArrays)
            {
                secondArrayIsBigger = true;
                equalArrays = false;
            }
        }
        if (equalArrays)
        {
            Console.WriteLine("After all, the two arrays are equal");
        }
        if (!equalArrays)
        {
            if (firstArrayIsBigger)
            {
                Console.WriteLine("After all, the first array is bigger");
            }
            if (secondArrayIsBigger)
            {
                Console.WriteLine("After all, the second array is bigger");
            }
        }
    }
}