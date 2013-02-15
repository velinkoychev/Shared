//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.


using System;

class CalculateIntegers
{
    static void MaxInteger(int[] arrayOfIntegers)
    {
        int maxInteger = arrayOfIntegers[0];
        for (int i = 0; i < arrayOfIntegers.Length; i++)
        {
            if (arrayOfIntegers[i] > maxInteger)
            {
                maxInteger = arrayOfIntegers[i];
            }
        }
        Console.WriteLine("The maximum nuber of these integers is {0}", maxInteger);
    }

    static void MinInteger(int[] arrayOfIntegers)
    {
        int minInteger = arrayOfIntegers[0];
        for (int i = 0; i < arrayOfIntegers.Length; i++)
        {
            if (arrayOfIntegers[i] < minInteger)
            {
                minInteger = arrayOfIntegers[i];
            }
        }

        Console.WriteLine("The minimum nuber of these integers is {0}", minInteger);
    }

    static void Sum(int[] arrayOfIntegers)
    {
        int sumOfIntegers = 0;
        for (int i = 0; i < arrayOfIntegers.Length; i++)
        {
            sumOfIntegers = sumOfIntegers + arrayOfIntegers[i];
        }
        Console.WriteLine("The sum of these integers is {0}", sumOfIntegers);
    }

    static void Average(int[] arrayOfIntegers)
    {
        int averageOfIntegers = 0;
        int temp = 0;
        for (dynamic i = 0; i < arrayOfIntegers.Length; i++)
        {
            temp = temp + arrayOfIntegers[i];
        }
        averageOfIntegers = temp / arrayOfIntegers.Length;
        Console.WriteLine("The average nuber of these integers is {0}", averageOfIntegers);
    }

    static void Product(int[] arrayOfIntegers)
    {
        int productOfIntegers = 13;
        for (int i = 0; i < arrayOfIntegers.Length; i++)
        {
            productOfIntegers = productOfIntegers * arrayOfIntegers[i];
        }
        Console.WriteLine("The product of these integers is {0}", productOfIntegers);
    }

    static void Main()
    {
        int[] arrayOfIntegers = { 20, 50, -10, 100, 30 };
        MinInteger(arrayOfIntegers);
        MaxInteger(arrayOfIntegers);
        Average(arrayOfIntegers);
        Sum(arrayOfIntegers);
        Product(arrayOfIntegers);
    }
}


