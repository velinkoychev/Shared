//Write a method that reverses the digits of given decimal number. Example: 256  652


using System;

class ReverseTheDigits
{
    static decimal ReverseDigits(string numberToReverse)
    {
        decimal reversedNumber = 0;
        bool numberIsNegative = false;
        for (int i = 0, power = 0; i < numberToReverse.Length ; i++,power++)
        {
            if ((i==0)&&(numberToReverse[i]=='-')) //// we want to check if the number is negative
            {
                numberIsNegative = true;
                power--;
                continue;
                
            }
            reversedNumber = reversedNumber + (Convert.ToInt32(numberToReverse[i]) - 48) * (decimal)Math.Pow(10, power);
            //we are using Math.Pow because the program is small and don't require that much quickness

        }
        if (numberIsNegative)
        {
            reversedNumber = reversedNumber * (-1);
        }
        return reversedNumber;
    }

    static void Main()
    {
        string numberToReverse = "";
        Console.Write("Please, enter the number you want to reverse= ");
        numberToReverse = Console.ReadLine();
        decimal reversedNumber = ReverseDigits(numberToReverse);
        Console.WriteLine(reversedNumber);
    }
}