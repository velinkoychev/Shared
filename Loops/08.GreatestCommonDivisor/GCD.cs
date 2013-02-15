using System;

class GCD
{
    static void Main()
    {
        int numberA, numberB;
        bool correctInput;
        do
        {
            Console.Write("Please, write number A= ");
            correctInput = int.TryParse(Console.ReadLine(), out numberA);
        }
        while (!correctInput);
        do
        {
            Console.Write("Please, write number N= ");
            correctInput = int.TryParse(Console.ReadLine(), out numberB);
        }
        while (!correctInput);
        while (numberA != 0 && numberB != 0)
        {
            if (numberA > numberB)
                numberA = numberA % numberB;
            else
                numberB = numberB % numberA;
        }
        if (numberA == 0)
            Console.WriteLine("The greatest common divisor = " + numberB );
        else
            Console.WriteLine("The greatest common divisor = " + numberA);
    }
}

