// Write a program that reads a string from the console and prints all different letters 
//in the string along with information how many times each letter is found. 

using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

class CountLetters
{
    static void Main()
    {
        string enteredText = "Write a program that reads a string from the console and prints all different letters 3#1$";
        SearchForLetters(enteredText);
        Console.WriteLine("Please, enter the text: ");
        enteredText = Console.ReadLine();
        SearchForLetters(enteredText);
    }

    private static void SearchForLetters(string enteredText)
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        string pattern = @"[a-z]{1}";
        string textToSearch = enteredText.ToLower();
        Match match = Regex.Match(textToSearch, pattern);
        while (match.Success)
        {
            int value;
            //we will use TryGetValue because it is more efficient
            if (dictionary.TryGetValue(match.Value, out value))
            {
                dictionary[match.Value] = value + 1;
            }
            else
            {
                dictionary.Add(match.Value, 1);
            }
            match = match.NextMatch();
        }
        foreach (var item in dictionary.OrderByDescending(i => i.Value))
        {
            Console.WriteLine(item);
        }

    }

}
