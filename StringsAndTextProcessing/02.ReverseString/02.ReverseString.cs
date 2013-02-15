//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".

using System;
class ReverseString
{
    static void Main()
    {
        Console.Write("Please, write your string: ");
        string enteredString = Console.ReadLine();
        char[] charArrayOfString = enteredString.ToCharArray();
        Array.Reverse(charArrayOfString);
        Console.Write("The reversed string is: ");
        Console.WriteLine(charArrayOfString);
    }
}

