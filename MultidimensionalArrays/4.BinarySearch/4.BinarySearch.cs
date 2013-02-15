//Write a program, that reads from the console an array of N integers and an integer K, 
// sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 


using System;
class BinarySearch
{
    static int[] ReadArray()
    {
        // Enter the lenght of the array and check if is entered correctly

        int arrayLength = 0;
        bool correctInput = false;
        while (!correctInput)
        {
            Console.Write("Please, enter the length of the array = ");
            correctInput = int.TryParse(Console.ReadLine(), out arrayLength);
        }
        // enter the array while checking if the entered values are correct
        correctInput = false;
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
        return arrayOfIntegers;

    }
    static void Main()
    {
        int[] arrayOfStrings = ReadArray();
        Array.Sort(arrayOfStrings);
        bool correctInput = false;
        int numberK = int.MinValue;
        while (!correctInput)
        {
            Console.Write("Please, enter the number K = ");
            correctInput = int.TryParse(Console.ReadLine(), out numberK);
        }
        int index = Array.BinarySearch(arrayOfStrings, numberK);
        if (arrayOfStrings[0] > numberK)
        {
            Console.WriteLine("All numbers are bigger than number K");
        }
        else if (numberK > arrayOfStrings[arrayOfStrings.Length - 1])
        {
            Console.WriteLine("The number you are searching for equals {0}", arrayOfStrings[arrayOfStrings.Length - 1]);
        }
        else if (index >= 0)
        {
            Console.WriteLine("The number you are searching for equals {0}", arrayOfStrings[index]);
        }
        else
        {
            index = ~index;
            Console.WriteLine("The number you are searching for equals {0}", arrayOfStrings[index - 1]);
        }
    }
}

