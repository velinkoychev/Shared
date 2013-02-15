//* Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. Example:
//	n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}


using System;
class PrintAllPermutations
{
    static int numbers;
    static int numberOfIterations;
    static int[] loops;

    static void Main()
    {
        Console.Write("Number N = ");
        numbers = int.Parse(Console.ReadLine());
        numberOfIterations = numbers;
        loops = new int[numbers];
        GenerateCombinationsNestedLoops(0); // we will use recursion 
    }
    static void GenerateCombinationsNestedLoops(int currentLoop)
    {
        if (currentLoop == numbers) // check for bottom
        {
            for (int i = 0; i < numbers; i++)
            {
                Console.Write("{0} ", loops[i]);
            }
            Console.WriteLine();
            return;
        }
        for (int counter = 1; counter <= numberOfIterations; counter++)
        {
            loops[currentLoop] = counter;
            GenerateCombinationsNestedLoops(currentLoop + 1);
        }
    }
}
