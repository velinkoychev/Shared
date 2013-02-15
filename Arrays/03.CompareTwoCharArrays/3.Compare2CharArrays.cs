using System;
class Compare2CharArrays
{
    static void Main()
    {
        //Write a program that compares two char arrays lexicographically (letter by letter).


        // Enter the lenght of the arrays and check if they are entered correctly
        int arrayLength1 = 0;
        int arrayLength2 = 0;
        bool correctInput = false;
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
        char[] arrayOfChars = new char[arrayLength1];
        char[] arrayOfChars2 = new char[arrayLength2];
        for (int i = 0; i < arrayLength1; i++)
        {
            while (!correctInput)
            {
                Console.Write("Array1[{0}] = ", i);
                correctInput = char.TryParse(Console.ReadLine(), out arrayOfChars[i]);
            }
            correctInput = false;
        }
        for (int i = 0; i < arrayLength2; i++)
        {
            while (!correctInput)
            {
                Console.Write("Array1[{0}] = ", i);
                correctInput = char.TryParse(Console.ReadLine(), out arrayOfChars2[i]);
            }
            correctInput = false;
        }
        // comparing them letter by letter, but only till their common length
        int minLength = Math.Min(arrayLength1, arrayLength2); // get the min array length
        bool arraysEqual = true;// check if the arrays are equal
        for (int i = 0; i < minLength; i++)
        {
            if (arrayOfChars[i] == arrayOfChars2[i])
            {
                continue;
            }
            if (arrayOfChars[i] > arrayOfChars2[i])
            {
                Console.WriteLine("The second array lexicographically precedes the first array.");
                arraysEqual = false;
                break;
            }
            if (arrayOfChars[i] < arrayOfChars2[i])
            {
                Console.WriteLine("The first array lexicographically precedes the second array.");
                arraysEqual = false;
                break;
            }
        }
        // check their lengths if they are not equal
        if ((arrayLength1 > arrayLength2) && arraysEqual)
        {
            Console.WriteLine("The second array lexicographically precedes the first array.");
            arraysEqual = false;
        }
        if ((arrayLength1 < arrayLength2) && arraysEqual)
        {
            Console.WriteLine("The first array lexicographically precedes the second array.");
            arraysEqual = false;
        }
        if (arraysEqual)
        {
            Console.WriteLine("The two char arrays are equal");
        }
    }
}

