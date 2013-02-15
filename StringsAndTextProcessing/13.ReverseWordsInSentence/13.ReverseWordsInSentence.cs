//Write a program that reverses the words in given sentence.
//Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
class ReverseWordsInSentence
{
    static void Main()
    {
        string str = "C# /is/ not C++, not PHP (and) not Delphi!";
        ReverseWords(str);
        Console.WriteLine("You can try yourself. Please enter your sentence = ");
        str = Console.ReadLine();
        ReverseWords(str);
    }

    private static void ReverseWords(string str)
    {
        string regex = @"[!,.?"":;\s/()]+"; ////use regex to find delimiters and words
        //first add the words in List
        string[] wordsInArray = Regex.Split(str, regex);
        List<string> words = new List<string>(wordsInArray);
        List<string> delimiters = new List<string>();
        // add the delimiters in another List
        foreach (Match delimiter in Regex.Matches(str, regex))
            delimiters.Add(delimiter.Value);
        //And now build the new sentence
        StringBuilder newSentence = new StringBuilder();
        for (int i = 0; i < delimiters.Count; i++)
        {
            newSentence.Append((words[words.Count - 2 - i] + delimiters[i]));
        }
        Console.WriteLine(newSentence);
    }
}

