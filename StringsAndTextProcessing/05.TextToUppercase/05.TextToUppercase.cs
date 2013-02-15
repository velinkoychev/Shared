//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase.
//The tags cannot be nested. 

using System;
using System.Text;

class TextToUppercase
{
    static string ChangeToUppercase(string enteredText)
    {
        int startIndex = -1;
        int endIndex = -1;
        do
        {
            startIndex = enteredText.ToLower().IndexOf("<upcase>", startIndex + 1);
            endIndex = enteredText.ToLower().IndexOf("</upcase>", startIndex + 1);
            if (startIndex != -1)
            {
                // use .Replace to change the substrings
                enteredText = enteredText.Replace(enteredText.Substring(startIndex, endIndex - startIndex + 9),
                    enteredText.ToUpper().Substring(startIndex + 8, endIndex - startIndex - 8));
            }
        }
        while (startIndex != -1);
        return enteredText;
    }

    static void Main()
    {
        string enteredText = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine(ChangeToUppercase(enteredText));
        Console.WriteLine();
        Console.WriteLine("Please enter the text: ");
        enteredText = Console.ReadLine();
        Console.WriteLine(ChangeToUppercase(enteredText));
    }
}

