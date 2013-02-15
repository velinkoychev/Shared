using System;

class DevideBy2And5
{
    static void Main()
    {
        bool devideBy5And7;
        int checkValue;
        Console.Write("Write the value : ");
        if (int.TryParse(Console.ReadLine(), out checkValue)) // checking if the entered value is correct
        {
            devideBy5And7 = ((checkValue % 35) == 0);
            Console.WriteLine(devideBy5And7 ? "The value can be devided by 5 and 7 without remainder" : "The value can't be devided by 5 and 7 without remainder");
        }
        else
        {
            Console.WriteLine("Sorry, you have entered wrong number!");
        }
       
    }
}
