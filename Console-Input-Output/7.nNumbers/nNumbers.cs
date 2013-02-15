using System;

class nNumbers
{
    static void Main()
    {
        int numberN;
        int sumOfNNumbers=0;
        Console.Write("Please, write number n =  ");
        numberN = int.Parse(Console.ReadLine());
        while (numberN > 0)
        {
            int newNumber;
            Console.Write("Please, write new number = ");
            newNumber = int.Parse(Console.ReadLine());
            sumOfNNumbers = sumOfNNumbers + newNumber;
            numberN--;
        }
        Console.WriteLine("The sum of your number = {0}", sumOfNNumbers);
    }
}

