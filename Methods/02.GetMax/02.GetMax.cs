//Write a method GetMax() with two parameters that returns the bigger of two integers.3
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().


using System;
class GetMaxMethod
{
    static int GetMax(int integerNumber1, int integerNumber2)
    {
        int maxInteger = 0;
        if (integerNumber1 > integerNumber2)
        {
            maxInteger = integerNumber1;
        }
        else
        {
            maxInteger = integerNumber2;
        }
        return maxInteger;
    }

    static int ReadIntegerNumber()
    {
        int integerNumber = int.MinValue;
        bool correctInput = false;
        while (!correctInput)
        {
            Console.Write("Please, enter integer number =");
            correctInput = int.TryParse(Console.ReadLine(), out integerNumber);
        }
        return integerNumber;
    }

    static void Main()
    {
       int integerNumber1 = ReadIntegerNumber();
       int integerNumber2 = ReadIntegerNumber();
       int integerNumber3 = ReadIntegerNumber();
       Console.WriteLine("The biggest integer number is = {0}", GetMax(GetMax(integerNumber1, integerNumber2), integerNumber3)); 
    }

    
}
