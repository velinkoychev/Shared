// We are given a string containing a list of forbidden words and a text containing some of these words. 
//Write a program that replaces the forbidden words with asterisks. 

using System;
using System.Text;

class ForbiddenWords 
{
    static string enteredText = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
    static string forbiddenWords = "PHP, CLR, Microsoft";

    static string removeForbiddenWords()
    {
        //we will use StringBuilder in order to make the method faster
        StringBuilder textForEditing = new StringBuilder();
        textForEditing.Append(enteredText);
        //split the forbidden words
        char [] delimiters = new char[] {'.',' ',';',','};
        string[] forbiddenWordsArray = forbiddenWords.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in forbiddenWordsArray)
        {
            textForEditing=textForEditing.Replace(word, new string('*', word.Length));
        }
        return textForEditing.ToString();
    }
    static void Main()
    {
        Console.WriteLine(removeForbiddenWords());
        Console.WriteLine("If you want to try the program yourself, please enter the text: ");
        enteredText = Console.ReadLine();
        Console.Write("And now the forbidden words...");
        forbiddenWords = Console.ReadLine();
        Console.WriteLine(removeForbiddenWords());
    }
}
