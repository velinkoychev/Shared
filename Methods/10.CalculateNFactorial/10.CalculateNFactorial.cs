//Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

using System;
using System.Collections.Generic;
class CalculateNFactorial
{
    static void MultiplyNumbers(ref List<int> factorial, int numberN)
    {
        int indexPosition = 0;
        int overSum = 0; 
        while (indexPosition < factorial.Count)
        {
            int tempSum = factorial[indexPosition] * numberN + overSum;
            factorial[indexPosition] = tempSum % 10;
            overSum = tempSum / 10;
            indexPosition++;
            if ((overSum>0)&&(indexPosition == factorial.Count))
            {
                factorial.Add(0);
            }
        }
    }


    static void Main()
    {
        // enter number N
        int numberN = 0;
        bool correctInput = false;
        while (!correctInput)
        {
            Console.Write("Please, write n (1 <=n<= 100) = ");
            correctInput = int.TryParse(Console.ReadLine(), out numberN);
            if ((numberN > 100) || (numberN < 1))
            {
                correctInput = false;
            }
        }
        // use List to store big numbers with infinite amount of digits
        List<int> factorial = new List<int>();
        factorial.Add(1);
        int counter = 2;
        // go through all of the digits and multiply them with the new number
        while (counter <= numberN)
        {
            MultiplyNumbers(ref factorial, counter);
            counter++;
        }
        //reverse the digits
        factorial.Reverse();
        //print the new number
        foreach (int digit in factorial)
        {
            Console.Write(digit);
        }
        Console.WriteLine();

    }
}

