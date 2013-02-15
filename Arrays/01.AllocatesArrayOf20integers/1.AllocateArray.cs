using System;
class AllocateArray
{
    static void Main()
    {
        // Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
        //Print the obtained array on the console.

        // Create array
        int[] arrayOfIntegers = new int[20];
        for (int i = 0; i < 20; i++)
        {
            arrayOfIntegers[i] = i * 5;
        }
        // print array
        Console.WriteLine("Array:");
        foreach (int integer in arrayOfIntegers)
        {
            Console.WriteLine(integer);
        }
    }
}

