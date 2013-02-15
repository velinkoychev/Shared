using System;
class CheckIfThereIsSubsetEquals0
{
    static void Main()
    {
        bool isThereAnySubset = false;
        bool correctInput = false;
        int[] numbers = new int[5];
        Console.WriteLine("Please, write 5 integer numbers");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("number {0} = ",i+1 );
            correctInput = int.TryParse(Console.ReadLine(), out numbers[i]);
            if (!correctInput)
            {
                Console.WriteLine("Sorry, you have entered a wrong number! Please, try again!");
                Main();
            }
        }
        for (int i = 0; i < 5; i++)
        {
            if (numbers[i] == 0)
            {
                Console.WriteLine("The subset of {0} = 0", numbers [i]);
                isThereAnySubset = true;
            }
            for (int j = i + 1; j < 5; j++)
            {
                if (numbers[i] + numbers[j] == 0)
                {
                    Console.WriteLine("The subset of ({0})+({1}) = 0", numbers[i], numbers[j]);
                    isThereAnySubset = true;
                }
                for (int k = j + 1; k < 5; k++)
                {
                    if (numbers[i] + numbers[j] + numbers [k]== 0)
                    {
                        Console.WriteLine("The subset of ({0})+({1})+({2}) = 0", numbers[i], numbers[j], numbers[k]);
                        isThereAnySubset = true;
                        for (int m = k + 1; m < 5; m++)
                        {
                            if (numbers[i] + numbers[j] + numbers[k] + numbers[m] == 0)
                            {
                                Console.WriteLine("The subset of ({0})+({1})+({2})+({3}) = 0", numbers[i], numbers[j], numbers[k], numbers[m] );
                                isThereAnySubset = true;
                            }
                        }
                    }
                }
            }
        }
        if (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] == 0)
        {
            Console.WriteLine("The subset of ({0})+({1})+({2})+({3})+({4}) = 0", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
            isThereAnySubset = true;
        }
        if (!isThereAnySubset)
        {
            Console.WriteLine("There is no subset with sum = 0");
        }
    }
}

