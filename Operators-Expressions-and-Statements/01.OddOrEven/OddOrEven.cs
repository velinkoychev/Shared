using System;

class OddOrEven
{
    static void Main()
    {
        bool oddOrEven;
        int checkValue;
        Console.WriteLine("Write the value");
        int.TryParse(Console.ReadLine(), out checkValue); // checking if the entered value is correct
        oddOrEven = ((checkValue % 2) == 0);
        Console.WriteLine(oddOrEven ? "The value is even" : "The value is odd");
    }
}
