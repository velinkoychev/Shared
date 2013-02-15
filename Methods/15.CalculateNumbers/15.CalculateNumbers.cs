//* Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).


using System;
using System.Collections.Generic;

class CalculateNumbers
{
    static void MaxInteger<Т>(Т[] arrayOfIntegers)
    {
        dynamic maxInteger = arrayOfIntegers[0];
        for (dynamic i = 0; i < arrayOfIntegers.Length; i++)
        {
            if ((dynamic)arrayOfIntegers[i] > maxInteger)
            {
                maxInteger = arrayOfIntegers[i];
            }
        }
        Console.WriteLine("The maximum nuber of these integers is {0}", maxInteger);
    }

    static void MinInteger<Т>(Т[] arrayOfIntegers)
    {
        dynamic minInteger = arrayOfIntegers[0];
        for (int i = 0; i < arrayOfIntegers.Length; i++)
        {
            if ((dynamic)arrayOfIntegers[i] < minInteger)
            {
                minInteger = arrayOfIntegers[i];
            }
        }
        
        Console.WriteLine("The minimum nuber of these integers is {0}", minInteger );
    }

    static void Sum<Т>(Т[] arrayOfIntegers)
    {
        dynamic sumOfIntegers = 0;
        for (dynamic i = 0; i < arrayOfIntegers.Length; i++)
        {
            sumOfIntegers = sumOfIntegers + (dynamic)arrayOfIntegers[i];
        }
        Console.WriteLine("The sum of these integers is {0}", sumOfIntegers);
    }

    static void Average<Т>(Т[] arrayOfIntegers)
    {
        dynamic averageOfIntegers = 0;
        dynamic temp = 0;
        for (dynamic i = 0; i < arrayOfIntegers.Length; i++)
        {
            temp = temp + (dynamic)arrayOfIntegers[i];
        }
        averageOfIntegers = temp / (dynamic)arrayOfIntegers.Length;
        Console.WriteLine("The average nuber of these integers is {0}", averageOfIntegers);
    }

    static void Product<Т>(Т[] arrayOfIntegers)
    {
        dynamic productOfIntegers = 13;
        for (dynamic i = 0; i < arrayOfIntegers.Length; i++)
        {
            productOfIntegers = productOfIntegers * (dynamic)arrayOfIntegers[i];
        }
        Console.WriteLine("The product of these integers is {0}", productOfIntegers);
    }

    static void Main()
    {
        double[] arrayOfIntegers = { 2, 5, -10.5, 102, 30};
        MinInteger(arrayOfIntegers);
        MaxInteger(arrayOfIntegers);
        Average(arrayOfIntegers);
        Sum(arrayOfIntegers);
        Product(arrayOfIntegers);
    }
}


