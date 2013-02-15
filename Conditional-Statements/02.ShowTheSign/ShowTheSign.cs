using System;

class ShowTheSign
{
    static void Main()
    {
        double realNumber1, realNumber2, realNumber3;
        byte negativeNumbers = 0;
        Console.Write("Please, write the first real number = ");
        realNumber1 = double.Parse(Console.ReadLine());
        Console.Write("Please, write the second real number = ");
        realNumber2 = double.Parse(Console.ReadLine());
        Console.Write("Please, write the third real number = ");
        realNumber3 = double.Parse(Console.ReadLine());
        if (realNumber1 < 0)
        {
            negativeNumbers++;
        }
        if (realNumber2 < 0)
        {
            negativeNumbers++;
        }
        if (realNumber3 < 0)
        {
            negativeNumbers++;
        }
        if ((realNumber1 == 0) || (realNumber2 == 0) || (realNumber3 == 0))
        {
            Console.WriteLine("The product is 0");
        }
        else if ((negativeNumbers % 2) == 0)
            Console.WriteLine("The sign of the product of the three real numbers is + ");
        else if ((negativeNumbers % 2) != 0)
            Console.WriteLine("The sign of the product of the three real numbers is - ");
        else
            Console.WriteLine("There is an error");
    }
}
