//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
//Print the result string into the console.


using System;
class StringOf20Characters
{
    static void Main()
    {
        string enteredString;
        do
        {
            Console.Write("Please enter a string with maximum 20 characters: ");
            enteredString = Console.ReadLine();
        }
        while (enteredString.Length > 20);
        enteredString = enteredString.PadRight(20, '*');
        Console.WriteLine(enteredString);
    }
}
