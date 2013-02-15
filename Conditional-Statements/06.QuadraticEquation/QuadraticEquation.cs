using System;
class QuadraticEquation
{
    static void Main()
    {
        double coefficientA, coefficientB, coefficientC, diskriminanta, realRoot1, realRoot2;
        Console.Write("Please, write coefficient a... ");
        coefficientA = double.Parse(Console.ReadLine());
        Console.Write("Please, write coefficient b... ");
        coefficientB = double.Parse(Console.ReadLine());
        Console.Write("Please, write coefficient c... ");
        coefficientC = double.Parse(Console.ReadLine());
        diskriminanta = coefficientB * coefficientB - 4 * coefficientA * coefficientC;
        if (diskriminanta > 0)
        {
            realRoot1 = (-coefficientB + Math.Sqrt(diskriminanta)) / (2 * coefficientA);
            realRoot2 = (-coefficientB - Math.Sqrt(diskriminanta)) / (2 * coefficientA);
            Console.WriteLine("The real roots are: x1= {0}; x2= {1}", realRoot1, realRoot2);
        }
        else
        {
            if (diskriminanta == 0)
            {
                realRoot1 = (-coefficientB) / (2 * coefficientA);
                Console.WriteLine("The real roots are: x1= X2={0};", realRoot1);
            }
            else
            {
                Console.WriteLine("There are no real roots");
            }
        }
    }
}


