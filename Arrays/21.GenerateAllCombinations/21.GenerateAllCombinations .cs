//Write a program that reads two numbers N and K and generates all 
//the combinations of K distinct elements from the set [1..N]. Example:
//N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}



using System;
class GenerateAllCombinations
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
            if (currentLoop == 0)
            {
                loops[currentLoop] = counter;
                GenerateCombinationsNestedLoops(currentLoop + 1);
            }
            else if (currentLoop != 0) // now we want to check if we have already used the number
            {
                if (counter > loops[currentLoop - 1]) // if we haven't ==> we will use it
                {
                    loops[currentLoop] = counter;
                    GenerateCombinationsNestedLoops(currentLoop + 1);
                }
                else // if we have ==> we continue to the next
                {
                    continue;
                }
            }
        }
    }
}
