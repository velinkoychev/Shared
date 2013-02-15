using System;

class KElementsFromArray
{
    static void Main()
    {
        //Write a program that reads two integer numbers N and K and an array of N elements from the console.
        //Find in the array those K elements that have maximal sum.

        
        // Enter the lenght of the array (number N) and number K and check if is entered correctly

        int arrayLengthN = 0;
        int numberK = 0;
        bool correctInput = false;
        while (!correctInput)
        {
            Console.Write("Please, enter number N - the length of the array = ");
            correctInput = int.TryParse(Console.ReadLine(), out arrayLengthN);
        }
        correctInput = false;
        while (!correctInput)
        {
            Console.Write("Please, enter number K (K<=N) = ");
            correctInput = int.TryParse(Console.ReadLine(), out numberK);
            if (numberK > arrayLengthN)
            {
                correctInput = false;
            }
        }
        // enter the array while checking if the entered values are correct
        int[] arrayOfIntegers = new int[arrayLengthN];
        for (int i = 0; i < arrayLengthN; i++)
        {
            while (!correctInput)
            {
                Console.Write("Array[{0}] = ", i);
                correctInput = int.TryParse(Console.ReadLine(), out arrayOfIntegers[i]);
            }
            correctInput = false;
        }
        int sum = 0;
        int bestSum = 0;
        for (int i = 0; i < numberK; i++)
        {
            bestSum = bestSum + arrayOfIntegers[i];
            sum = bestSum;
        }

        // we are sorting the array to find the biggest numbers. 
        // It's not the fastest way, but in this task it is not required to be efficient.

        Array.Sort(arrayOfIntegers);
        Array.Reverse(arrayOfIntegers);
        for (int i = 0; i < numberK; i++)
        {
            bestSum = bestSum + arrayOfIntegers[i];
        }


        // if we want to find elements that are consecutive we can use this code 
        //(but I think it is not required):


        //int bestStartIndex = 0;
        //int startIndex = 0;
        //for (int i = numberK; i < arrayLengthN; i++)
        //{
        //    sum = sum + arrayOfIntegers[i] - arrayOfIntegers[i - numberK];
        //    if (sum>bestSum)
        //    {
        //        bestSum = sum;
        //        startIndex = i - numberK + 1;
        //    }
        //}


        Console.WriteLine("The maximal sum of K elements = {0} ", bestSum);
        for (int i = 0; i < numberK; i++)
        {
            Console.Write("{0} ", arrayOfIntegers[i]);
        }
        Console.WriteLine();    
    }
}
