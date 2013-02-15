using System;

class FindTheBiggestInteger
{
    static void Main()
    {
        Console.Write("Please, write the first integer = ");
        int firstInteger = int.Parse(Console.ReadLine());
        Console.Write("Please, write the second integer = ");
        int secondInteger = int.Parse(Console.ReadLine());
        Console.Write("Please, write the third integer = ");
        int thirdInteger = int.Parse(Console.ReadLine());
        int theBiggestInteger = firstInteger;
        if (secondInteger > firstInteger)
        {
            theBiggestInteger = secondInteger;
            if (thirdInteger > secondInteger)
            {
                theBiggestInteger = thirdInteger;
            }
        }
        else if (thirdInteger > firstInteger)
        {
            theBiggestInteger = thirdInteger;
        }
        Console.WriteLine("The biggest integer is {0}", theBiggestInteger);
    }
}

