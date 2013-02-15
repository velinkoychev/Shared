//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).


using System;
using System.Linq;

class SortByLength
{
    static string[] ReadArray()
    {
        // Enter the lenght of the array and check if is entered correctly

        int arrayLength = 0;
        bool correctInput = false;
        while (!correctInput)
        {
            Console.Write("Please, enter the length of the array = ");
            correctInput = int.TryParse(Console.ReadLine(), out arrayLength);
        }
        // enter the array
        string[] arrayOfStrings = new string[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Array[{0}] = ", i);
            arrayOfStrings[i] = Console.ReadLine();
        }
        return arrayOfStrings;

    }
    
    static void Main()
    {
        string[] arrayOfIntegers = ReadArray();
        foreach (var item in arrayOfIntegers.OrderBy(uStrings => uStrings.Length))
        {
            Console.WriteLine(item);
        }
    }
}

