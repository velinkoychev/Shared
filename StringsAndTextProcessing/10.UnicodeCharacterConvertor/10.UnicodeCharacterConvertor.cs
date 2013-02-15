//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 

using System;
class UnicodeCharacterConvertor
{
    static void Main()
    {
        Console.Write("Please, enter the string = ");
        string enteredString = Console.ReadLine();
        ConvertToUnicodeLiterals(enteredString);

    }

    private static void ConvertToUnicodeLiterals(string enteredString)
    {
        foreach (char c in enteredString)
        {
            Console.Write(@"\u{0:X4}", (int)c);
        }
        Console.WriteLine();
    }
}

