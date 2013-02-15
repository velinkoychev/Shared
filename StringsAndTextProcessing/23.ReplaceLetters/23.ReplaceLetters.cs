//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. 
//Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

using System;
using System.Text.RegularExpressions;

class ReplaceLetters
{
    static void Main()
    {
        string enteredText = "aaaaabbbbbcdddeeeedssaa // jjj1111222 Numbers should not be changed!";
        ReplaceConsecutiveLetters(enteredText);
        Console.Write("Enter your text: ");
        enteredText = Console.ReadLine();
        ReplaceConsecutiveLetters(enteredText);
    }

    private static void ReplaceConsecutiveLetters(string enteredText)
    {
        string newText = Regex.Replace(enteredText, @"([a-zA-Z])\1+", "$1");
        Console.WriteLine(newText);
    }
}
