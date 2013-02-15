using System;
class TwoNumbers
{
    static void Main()
    {
        uint number1, number2, startNummber, endNumber;
        uint numberP = 0;
        Console.Write("Please, write the first positive integer number= ");
        number1 = uint.Parse(Console.ReadLine());
        Console.Write("Please, write the second positive integer number= ");
        number2 = uint.Parse(Console.ReadLine());
        if (number2 >=number1) 
        {
            startNummber = number1;
            endNumber = number2;
        }
        else
        {
            startNummber = number2;
            endNumber = number1;
        }
        while (startNummber <= endNumber)
        {
            if ((startNummber % 5) == 0)
            {
                numberP++;
                startNummber++;
            }
            else
            {
                startNummber++; 
            }
        }
        Console.WriteLine("Number P = {0}", numberP);
    }
}
