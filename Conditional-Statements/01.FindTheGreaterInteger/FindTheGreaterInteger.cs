using System;

class FindTheGreaterInteger
{
    static void Main()
    {
        Console.Write("Please, enter the first integer number = ");
        int variable1 = int.Parse(Console.ReadLine());
        Console.Write("Please, enter the second integer number = ");
        int variable2 = int.Parse(Console.ReadLine());
        if (variable1 > variable2)
        {
            int tempVariable = variable1;
            variable1 = variable2;
            variable2 = tempVariable;
            Console.WriteLine("Your first number was greater than the second, so I switched their places!");
        }
        else
        {
            Console.WriteLine("Your second number was greater than the first!");
        }
    }
}

