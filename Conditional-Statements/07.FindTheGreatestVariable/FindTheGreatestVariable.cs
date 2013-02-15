using System;

class FindTheGreatestVariable
{
    static void Main()
    {
        Console.Write("Please, write the first variable V1 = ");
        double variable1 = double.Parse(Console.ReadLine());
        Console.Write("V2 = ");
        double variable2 = double.Parse(Console.ReadLine());
        Console.Write("V3 = ");
        double variable3 = double.Parse(Console.ReadLine());
        Console.Write("V4 = ");
        double variable4 = double.Parse(Console.ReadLine());
        Console.Write("V5 = ");
        double variable5 = double.Parse(Console.ReadLine());
        double greatestVariable = variable1;
        if (variable2 > greatestVariable)
        {
            greatestVariable = variable2;    
        }
        if (variable3 > greatestVariable)
        {
            greatestVariable = variable3;
        }
        if (variable4 > greatestVariable)
        {
            greatestVariable = variable4;
        }
        if (variable5 > greatestVariable)
        {
            greatestVariable = variable5;
        }
        Console.WriteLine("The greatest variable that you entered is {0}", greatestVariable);
    }
}

