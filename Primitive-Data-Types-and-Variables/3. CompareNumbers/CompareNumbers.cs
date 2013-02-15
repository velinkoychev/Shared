using System;

class CompareNumbers
{
    static void Main()
    {
        Console.WriteLine(" Write the first number ");
        decimal numberA = decimal.Parse(Console.ReadLine());
        numberA = Math.Round(numberA, 6);
        Console.WriteLine(" Write the second number ");
        decimal numberB = decimal.Parse(Console.ReadLine());
        numberB = Math.Round(numberB, 6);
        bool compare = (numberA ==numberB);
        if (compare)
        {
            Console.WriteLine("true, they are equal");
        }
        else
        {
            Console.WriteLine("false, they are not equeal");
        }
    }
}
