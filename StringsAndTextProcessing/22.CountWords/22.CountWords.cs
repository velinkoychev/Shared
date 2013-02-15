//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

class CountWords
{
    static void Main()
    {
        string enteredText = "Just for the test. I am TESTING the test for TEST reasons. Of course, make your own testing, please!";
        SearchForLetters(enteredText);
        Console.WriteLine("Please, enter the text: ");
        enteredText = Console.ReadLine();
        SearchForLetters(enteredText);
    }

    private static void SearchForLetters(string enteredText)
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        string textToSearch = enteredText.ToLower();
        string pattern = @"\b\w+\b";
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

