// Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
//	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}


using System;

class GenerateAllVariations
{
    static int distinctElements;
    static int numbersInSet;
    static int[] loops;
    static void Main()
    {
        
        Console.Write("Please, enter number N = ");
        numbersInSet = int.Parse(Console.ReadLine());
        Console.Write("Please, enter number K = ");
        distinctElements = int.Parse(Console.ReadLine());
        loops = new int[distinctElements];
        GenerateCombinationsNestedLoops(0);

    }
    static void GenerateCombinationsNestedLoops(int currentLoop)
    {
        if (currentLoop == distinctElements)
        {
            for (int i = 0; i < distinctElements; i++)
            {
                Console.Write("{0} ", loops[i]);
            }
            Console.WriteLine();
            return;
        }
        for (int counter = 1; counter <= numbersInSet; counter++)
        {
            loops[currentLoop] = counter;
            GenerateCombinationsNestedLoops(currentLoop + 1);
        }
    }
}
