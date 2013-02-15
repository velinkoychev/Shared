using System;

class ThirdDigitIs7
{
    static void Main()
    {
        bool thirdDigitIs7;
        int checkValue;
        Console.WriteLine("Write the value");
        int.TryParse(Console.ReadLine(), out checkValue); // checking if the entered value is correct
        checkValue /= 100;
        thirdDigitIs7 = ((checkValue % 10) == 7);
        Console.WriteLine(thirdDigitIs7 ? "The value is seven" : "The value is not seven");
    }
}
